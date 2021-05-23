
namespace _4PD_Saugumas.Forms
{
    partial class LoginForm
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
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.pswLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(171, 84);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '#';
            this.passwordTxt.Size = new System.Drawing.Size(243, 26);
            this.passwordTxt.TabIndex = 9;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(171, 49);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(243, 26);
            this.usernameTxt.TabIndex = 8;
            // 
            // pswLbl
            // 
            this.pswLbl.AutoSize = true;
            this.pswLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswLbl.Location = new System.Drawing.Point(69, 84);
            this.pswLbl.Name = "pswLbl";
            this.pswLbl.Size = new System.Drawing.Size(96, 20);
            this.pswLbl.TabIndex = 7;
            this.pswLbl.Text = "Slaptažodis:";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(36, 52);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(129, 20);
            this.userNameLbl.TabIndex = 6;
            this.userNameLbl.Text = "Vartotojo vardas:";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(208, 123);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(89, 34);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Prisijungti";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 197);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.pswLbl);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.LoginBtn);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label pswLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Button LoginBtn;
    }
}