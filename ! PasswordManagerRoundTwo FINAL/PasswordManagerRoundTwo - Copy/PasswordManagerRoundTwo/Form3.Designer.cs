namespace PasswordManagerRoundTwo
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.appTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.ApplicationNameText = new System.Windows.Forms.Label();
            this.EmailUsernameText = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PasswordManagerRoundTwo.DataSet1();
            this.tableTableAdapter = new PasswordManagerRoundTwo.DataSet1TableAdapters.TableTableAdapter();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // appTxt
            // 
            this.appTxt.Location = new System.Drawing.Point(221, 54);
            this.appTxt.Name = "appTxt";
            this.appTxt.Size = new System.Drawing.Size(204, 20);
            this.appTxt.TabIndex = 0;
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(221, 90);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(204, 20);
            this.userTxt.TabIndex = 1;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(221, 125);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(204, 20);
            this.passTxt.TabIndex = 2;
            // 
            // ApplicationNameText
            // 
            this.ApplicationNameText.AutoSize = true;
            this.ApplicationNameText.ForeColor = System.Drawing.Color.White;
            this.ApplicationNameText.Location = new System.Drawing.Point(125, 57);
            this.ApplicationNameText.Name = "ApplicationNameText";
            this.ApplicationNameText.Size = new System.Drawing.Size(90, 13);
            this.ApplicationNameText.TabIndex = 3;
            this.ApplicationNameText.Text = "Application Name";
            // 
            // EmailUsernameText
            // 
            this.EmailUsernameText.AutoSize = true;
            this.EmailUsernameText.ForeColor = System.Drawing.Color.White;
            this.EmailUsernameText.Location = new System.Drawing.Point(125, 93);
            this.EmailUsernameText.Name = "EmailUsernameText";
            this.EmailUsernameText.Size = new System.Drawing.Size(91, 13);
            this.EmailUsernameText.TabIndex = 4;
            this.EmailUsernameText.Text = "Email / Username";
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.ForeColor = System.Drawing.Color.White;
            this.PasswordText.Location = new System.Drawing.Point(125, 125);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(53, 13);
            this.PasswordText.TabIndex = 5;
            this.PasswordText.Text = "Password";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(128, 172);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(297, 50);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.applicationNameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(492, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 381);
            this.dataGridView1.TabIndex = 7;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(517, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(439, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(962, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 20);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(492, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // applicationNameDataGridViewTextBoxColumn
            // 
            this.applicationNameDataGridViewTextBoxColumn.DataPropertyName = "ApplicationName";
            this.applicationNameDataGridViewTextBoxColumn.HeaderText = "ApplicationName";
            this.applicationNameDataGridViewTextBoxColumn.Name = "applicationNameDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(128, 229);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(149, 27);
            this.ButtonEdit.TabIndex = 11;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(284, 229);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(141, 27);
            this.ButtonDelete.TabIndex = 12;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.EmailUsernameText);
            this.Controls.Add(this.ApplicationNameText);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.appTxt);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox appTxt;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label ApplicationNameText;
        private System.Windows.Forms.Label EmailUsernameText;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonDelete;
    }
}