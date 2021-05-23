
namespace _4PD_Saugumas.Forms
{
    partial class RegisterForm
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
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.confirmPassTxt = new System.Windows.Forms.TextBox();
            this.confirmPswLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(180, 57);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '#';
            this.passwordTxt.Size = new System.Drawing.Size(243, 26);
            this.passwordTxt.TabIndex = 14;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(180, 22);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(243, 26);
            this.usernameTxt.TabIndex = 13;
            // 
            // pswLbl
            // 
            this.pswLbl.AutoSize = true;
            this.pswLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswLbl.Location = new System.Drawing.Point(78, 57);
            this.pswLbl.Name = "pswLbl";
            this.pswLbl.Size = new System.Drawing.Size(96, 20);
            this.pswLbl.TabIndex = 12;
            this.pswLbl.Text = "Slaptažodis:";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(45, 25);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(129, 20);
            this.userNameLbl.TabIndex = 11;
            this.userNameLbl.Text = "Vartotojo vardas:";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(224, 134);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(89, 34);
            this.RegisterBtn.TabIndex = 10;
            this.RegisterBtn.Text = "Registruotis";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // confirmPassTxt
            // 
            this.confirmPassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassTxt.Location = new System.Drawing.Point(180, 89);
            this.confirmPassTxt.Name = "confirmPassTxt";
            this.confirmPassTxt.PasswordChar = '#';
            this.confirmPassTxt.Size = new System.Drawing.Size(243, 26);
            this.confirmPassTxt.TabIndex = 15;
            // 
            // confirmPswLbl
            // 
            this.confirmPswLbl.AutoSize = true;
            this.confirmPswLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPswLbl.Location = new System.Drawing.Point(21, 92);
            this.confirmPswLbl.Name = "confirmPswLbl";
            this.confirmPswLbl.Size = new System.Drawing.Size(153, 20);
            this.confirmPswLbl.TabIndex = 16;
            this.confirmPswLbl.Text = "Patvirtinti slaptažodį:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 191);
            this.Controls.Add(this.confirmPswLbl);
            this.Controls.Add(this.confirmPassTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.pswLbl);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.RegisterBtn);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label pswLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox confirmPassTxt;
        private System.Windows.Forms.Label confirmPswLbl;
    }
}