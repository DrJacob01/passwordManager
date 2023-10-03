namespace PasswordManagerRoundTwo
{
    partial class Form2
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
            this.GeneratePasswordButton = new System.Windows.Forms.Button();
            this.GeneratePasswordTextBox = new System.Windows.Forms.TextBox();
            this.SavePasswordButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GeneratePasswordButton
            // 
            this.GeneratePasswordButton.Location = new System.Drawing.Point(262, 109);
            this.GeneratePasswordButton.Name = "GeneratePasswordButton";
            this.GeneratePasswordButton.Size = new System.Drawing.Size(231, 37);
            this.GeneratePasswordButton.TabIndex = 0;
            this.GeneratePasswordButton.Text = "Generate Password";
            this.GeneratePasswordButton.UseVisualStyleBackColor = true;
            this.GeneratePasswordButton.Click += new System.EventHandler(this.GeneratePasswordButton_Click_1);
            // 
            // GeneratePasswordTextBox
            // 
            this.GeneratePasswordTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GeneratePasswordTextBox.Location = new System.Drawing.Point(262, 153);
            this.GeneratePasswordTextBox.Name = "GeneratePasswordTextBox";
            this.GeneratePasswordTextBox.Size = new System.Drawing.Size(231, 20);
            this.GeneratePasswordTextBox.TabIndex = 1;
            this.GeneratePasswordTextBox.TextChanged += new System.EventHandler(this.GeneratePasswordTextBox_TextChanged);
            // 
            // SavePasswordButton
            // 
            this.SavePasswordButton.Location = new System.Drawing.Point(262, 205);
            this.SavePasswordButton.Name = "SavePasswordButton";
            this.SavePasswordButton.Size = new System.Drawing.Size(230, 30);
            this.SavePasswordButton.TabIndex = 2;
            this.SavePasswordButton.Text = "Save";
            this.SavePasswordButton.UseVisualStyleBackColor = true;
            this.SavePasswordButton.Click += new System.EventHandler(this.SavePasswordButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(262, 328);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(231, 23);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Logout Button";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.SavePasswordButton);
            this.Controls.Add(this.GeneratePasswordTextBox);
            this.Controls.Add(this.GeneratePasswordButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GeneratePasswordButton;
        private System.Windows.Forms.TextBox GeneratePasswordTextBox;
        private System.Windows.Forms.Button SavePasswordButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}