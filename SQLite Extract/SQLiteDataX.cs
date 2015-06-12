using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

namespace SQLite_Extract
{
    public partial class SQLiteDataX : Form
    {
        public SQLiteDataX()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "sqlite db files (*.db)|*.db";
                ofd.Multiselect = false;
                ofd.Title = "Find the sqlite db";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    txtDB.Text = ofd.FileName;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            var error = string.Empty;
            if (txtQuery.TextLength == 0)
                error = "No query to run...";
            if (txtDB.TextLength == 0 || !System.IO.File.Exists(txtDB.Text))
                error += "No sqlite db selected...";

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            var db = txtDB.Text;
            var query = txtQuery.Text;
            try
            {
                int rowsAffected = 0;
                var resultset = new DataTable();
                using (var sqlite = new SQLiteConnection(string.Format("Data Source={0}", db)))
                {
                    sqlite.Open();

                    using (var cmd = sqlite.CreateCommand())
                    {
                        cmd.CommandText = query;

                        if (cboCommand.SelectedIndex == 0) // query
                        {
                            using (var adapter = new SQLiteDataAdapter(cmd))
                            {
                                adapter.Fill(resultset);
                            }
                        }
                        else // nonquery
                            rowsAffected = cmd.ExecuteNonQuery();
                    }

                    sqlite.Close();
                }

                if (resultset.Rows.Count > 0)
                {
                    dgvData.DataSource = resultset;
                    rowsAffected = resultset.Rows.Count;
                }

                lblRowCount.Text = string.Format("rows: {0}", resultset.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        private void SQLiteDataX_Load(object sender, EventArgs e)
        {
            cboCommand.SelectedIndex = 0;
        }
    }
}
