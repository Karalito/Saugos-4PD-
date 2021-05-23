
namespace _4PD_Saugumas.Forms
{
    partial class PswManagerForm
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
            this.NewPswBtn = new System.Windows.Forms.Button();
            this.UpdatePswBtn = new System.Windows.Forms.Button();
            this.FindPswBtn = new System.Windows.Forms.Button();
            this.DeletePswBtn = new System.Windows.Forms.Button();
            this.newPswGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveNewPswBtn = new System.Windows.Forms.Button();
            this.additionalInfoTxt = new System.Windows.Forms.TextBox();
            this.urlAppTxt = new System.Windows.Forms.TextBox();
            this.pswTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newPswGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewPswBtn
            // 
            this.NewPswBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPswBtn.Location = new System.Drawing.Point(12, 12);
            this.NewPswBtn.Name = "NewPswBtn";
            this.NewPswBtn.Size = new System.Drawing.Size(168, 37);
            this.NewPswBtn.TabIndex = 1;
            this.NewPswBtn.Text = "Naujas Slaptažodis";
            this.NewPswBtn.UseVisualStyleBackColor = true;
            this.NewPswBtn.Click += new System.EventHandler(this.NewPswBtn_Click);
            // 
            // UpdatePswBtn
            // 
            this.UpdatePswBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePswBtn.Location = new System.Drawing.Point(12, 66);
            this.UpdatePswBtn.Name = "UpdatePswBtn";
            this.UpdatePswBtn.Size = new System.Drawing.Size(168, 37);
            this.UpdatePswBtn.TabIndex = 2;
            this.UpdatePswBtn.Text = "Atnaujinti Slaptažodį";
            this.UpdatePswBtn.UseVisualStyleBackColor = true;
            this.UpdatePswBtn.Click += new System.EventHandler(this.UpdatePswBtn_Click);
            // 
            // FindPswBtn
            // 
            this.FindPswBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindPswBtn.Location = new System.Drawing.Point(12, 120);
            this.FindPswBtn.Name = "FindPswBtn";
            this.FindPswBtn.Size = new System.Drawing.Size(168, 37);
            this.FindPswBtn.TabIndex = 3;
            this.FindPswBtn.Text = "Rasti Slaptažodį";
            this.FindPswBtn.UseVisualStyleBackColor = true;
            this.FindPswBtn.Click += new System.EventHandler(this.FindPswBtn_Click);
            // 
            // DeletePswBtn
            // 
            this.DeletePswBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePswBtn.Location = new System.Drawing.Point(12, 173);
            this.DeletePswBtn.Name = "DeletePswBtn";
            this.DeletePswBtn.Size = new System.Drawing.Size(168, 37);
            this.DeletePswBtn.TabIndex = 4;
            this.DeletePswBtn.Text = "Ištrinti Slaptažodį";
            this.DeletePswBtn.UseVisualStyleBackColor = true;
            this.DeletePswBtn.Click += new System.EventHandler(this.DeletePswBtn_Click);
            // 
            // newPswGroupBox
            // 
            this.newPswGroupBox.Controls.Add(this.SaveNewPswBtn);
            this.newPswGroupBox.Controls.Add(this.additionalInfoTxt);
            this.newPswGroupBox.Controls.Add(this.urlAppTxt);
            this.newPswGroupBox.Controls.Add(this.pswTxt);
            this.newPswGroupBox.Controls.Add(this.userNameTxt);
            this.newPswGroupBox.Controls.Add(this.label4);
            this.newPswGroupBox.Controls.Add(this.label3);
            this.newPswGroupBox.Controls.Add(this.label2);
            this.newPswGroupBox.Controls.Add(this.label1);
            this.newPswGroupBox.Location = new System.Drawing.Point(186, 12);
            this.newPswGroupBox.Name = "newPswGroupBox";
            this.newPswGroupBox.Size = new System.Drawing.Size(680, 241);
            this.newPswGroupBox.TabIndex = 5;
            this.newPswGroupBox.TabStop = false;
            this.newPswGroupBox.Text = "Sukurti naują slaptažodį";
            // 
            // SaveNewPswBtn
            // 
            this.SaveNewPswBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveNewPswBtn.Location = new System.Drawing.Point(275, 185);
            this.SaveNewPswBtn.Name = "SaveNewPswBtn";
            this.SaveNewPswBtn.Size = new System.Drawing.Size(170, 29);
            this.SaveNewPswBtn.TabIndex = 6;
            this.SaveNewPswBtn.Text = "Išsaugoti";
            this.SaveNewPswBtn.UseVisualStyleBackColor = true;
            this.SaveNewPswBtn.Click += new System.EventHandler(this.SaveNewPswBtn_Click);
            // 
            // additionalInfoTxt
            // 
            this.additionalInfoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalInfoTxt.Location = new System.Drawing.Point(205, 149);
            this.additionalInfoTxt.Name = "additionalInfoTxt";
            this.additionalInfoTxt.Size = new System.Drawing.Size(417, 22);
            this.additionalInfoTxt.TabIndex = 7;
            // 
            // urlAppTxt
            // 
            this.urlAppTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlAppTxt.Location = new System.Drawing.Point(205, 118);
            this.urlAppTxt.Name = "urlAppTxt";
            this.urlAppTxt.Size = new System.Drawing.Size(417, 22);
            this.urlAppTxt.TabIndex = 6;
            // 
            // pswTxt
            // 
            this.pswTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswTxt.Location = new System.Drawing.Point(205, 86);
            this.pswTxt.Name = "pswTxt";
            this.pswTxt.Size = new System.Drawing.Size(417, 22);
            this.pswTxt.TabIndex = 5;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.Location = new System.Drawing.Point(205, 54);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(417, 22);
            this.userNameTxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Papildoma informacija:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "URL/Aplikacija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slaptažodis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vartotojo Vardas:";
            // 
            // PswManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 265);
            this.Controls.Add(this.newPswGroupBox);
            this.Controls.Add(this.DeletePswBtn);
            this.Controls.Add(this.FindPswBtn);
            this.Controls.Add(this.UpdatePswBtn);
            this.Controls.Add(this.NewPswBtn);
            this.Name = "PswManagerForm";
            this.Text = "PswManagerForm";
            this.newPswGroupBox.ResumeLayout(false);
            this.newPswGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewPswBtn;
        private System.Windows.Forms.Button UpdatePswBtn;
        private System.Windows.Forms.Button FindPswBtn;
        private System.Windows.Forms.Button DeletePswBtn;
        private System.Windows.Forms.GroupBox newPswGroupBox;
        private System.Windows.Forms.Button SaveNewPswBtn;
        private System.Windows.Forms.TextBox additionalInfoTxt;
        private System.Windows.Forms.TextBox urlAppTxt;
        private System.Windows.Forms.TextBox pswTxt;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}