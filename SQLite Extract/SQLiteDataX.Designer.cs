namespace SQLite_Extract
{
    partial class SQLiteDataX
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLiteDataX));
            this.txtDB = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCommand = new System.Windows.Forms.ComboBox();
            this.lblRowCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDB
            // 
            this.txtDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDB.Location = new System.Drawing.Point(69, 13);
            this.txtDB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(479, 20);
            this.txtDB.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(559, 13);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(85, 20);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "find db";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(17, 111);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.Size = new System.Drawing.Size(627, 214);
            this.dgvData.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "query";
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Location = new System.Drawing.Point(69, 37);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(479, 68);
            this.txtQuery.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(559, 77);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(85, 28);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "run sql";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "db";
            // 
            // cboCommand
            // 
            this.cboCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCommand.FormattingEnabled = true;
            this.cboCommand.Items.AddRange(new object[] {
            "query",
            "nonquery"});
            this.cboCommand.Location = new System.Drawing.Point(559, 37);
            this.cboCommand.Name = "cboCommand";
            this.cboCommand.Size = new System.Drawing.Size(85, 21);
            this.cboCommand.TabIndex = 7;
            // 
            // lblRowCount
            // 
            this.lblRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(17, 332);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(63, 13);
            this.lblRowCount.TabIndex = 8;
            this.lblRowCount.Text = "rows: 0";
            // 
            // SQLiteDataX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 350);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.cboCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtDB);
            this.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SQLiteDataX";
            this.Text = "SQLite Data Extractor";
            this.Load += new System.EventHandler(this.SQLiteDataX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCommand;
        private System.Windows.Forms.Label lblRowCount;
    }
}

