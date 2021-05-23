
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
            this.updatePswGroupBox = new System.Windows.Forms.GroupBox();
            this.UpdatePsw = new System.Windows.Forms.Button();
            this.updateAdditionalInfoTxt = new System.Windows.Forms.TextBox();
            this.updateURLtxt = new System.Windows.Forms.TextBox();
            this.updatePswTxt = new System.Windows.Forms.TextBox();
            this.updateUsernameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.deletePswGroupBox = new System.Windows.Forms.GroupBox();
            this.DeletePassword = new System.Windows.Forms.Button();
            this.usernameToDeletePswTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.findPswGroupBox = new System.Windows.Forms.GroupBox();
            this.CopyPswBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FindPswBtn2 = new System.Windows.Forms.Button();
            this.findPswTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowAllPswBtn = new System.Windows.Forms.Button();
            this.showPsw = new System.Windows.Forms.CheckBox();
            this.newPswGroupBox.SuspendLayout();
            this.updatePswGroupBox.SuspendLayout();
            this.deletePswGroupBox.SuspendLayout();
            this.findPswGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.newPswGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // updatePswGroupBox
            // 
            this.updatePswGroupBox.Controls.Add(this.UpdatePsw);
            this.updatePswGroupBox.Controls.Add(this.updateAdditionalInfoTxt);
            this.updatePswGroupBox.Controls.Add(this.updateURLtxt);
            this.updatePswGroupBox.Controls.Add(this.updatePswTxt);
            this.updatePswGroupBox.Controls.Add(this.updateUsernameTxt);
            this.updatePswGroupBox.Controls.Add(this.label5);
            this.updatePswGroupBox.Controls.Add(this.label6);
            this.updatePswGroupBox.Controls.Add(this.label7);
            this.updatePswGroupBox.Controls.Add(this.label8);
            this.updatePswGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePswGroupBox.Location = new System.Drawing.Point(186, 12);
            this.updatePswGroupBox.Name = "updatePswGroupBox";
            this.updatePswGroupBox.Size = new System.Drawing.Size(680, 241);
            this.updatePswGroupBox.TabIndex = 6;
            this.updatePswGroupBox.TabStop = false;
            this.updatePswGroupBox.Text = "Atnaujinti slaptažodį";
            // 
            // UpdatePsw
            // 
            this.UpdatePsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePsw.Location = new System.Drawing.Point(275, 185);
            this.UpdatePsw.Name = "UpdatePsw";
            this.UpdatePsw.Size = new System.Drawing.Size(170, 29);
            this.UpdatePsw.TabIndex = 6;
            this.UpdatePsw.Text = "Atnaujinti";
            this.UpdatePsw.UseVisualStyleBackColor = true;
            this.UpdatePsw.Click += new System.EventHandler(this.UpdatePsw_Click);
            // 
            // updateAdditionalInfoTxt
            // 
            this.updateAdditionalInfoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAdditionalInfoTxt.Location = new System.Drawing.Point(205, 149);
            this.updateAdditionalInfoTxt.Name = "updateAdditionalInfoTxt";
            this.updateAdditionalInfoTxt.Size = new System.Drawing.Size(417, 22);
            this.updateAdditionalInfoTxt.TabIndex = 7;
            // 
            // updateURLtxt
            // 
            this.updateURLtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateURLtxt.Location = new System.Drawing.Point(205, 118);
            this.updateURLtxt.Name = "updateURLtxt";
            this.updateURLtxt.Size = new System.Drawing.Size(417, 22);
            this.updateURLtxt.TabIndex = 6;
            // 
            // updatePswTxt
            // 
            this.updatePswTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePswTxt.Location = new System.Drawing.Point(205, 86);
            this.updatePswTxt.Name = "updatePswTxt";
            this.updatePswTxt.Size = new System.Drawing.Size(417, 22);
            this.updatePswTxt.TabIndex = 5;
            // 
            // updateUsernameTxt
            // 
            this.updateUsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateUsernameTxt.Location = new System.Drawing.Point(205, 54);
            this.updateUsernameTxt.Name = "updateUsernameTxt";
            this.updateUsernameTxt.Size = new System.Drawing.Size(417, 22);
            this.updateUsernameTxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Papildoma informacija:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "URL/Aplikacija:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Slaptažodis:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Vartotojo Vardas:";
            // 
            // deletePswGroupBox
            // 
            this.deletePswGroupBox.Controls.Add(this.DeletePassword);
            this.deletePswGroupBox.Controls.Add(this.usernameToDeletePswTxt);
            this.deletePswGroupBox.Controls.Add(this.label12);
            this.deletePswGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePswGroupBox.Location = new System.Drawing.Point(186, 12);
            this.deletePswGroupBox.Name = "deletePswGroupBox";
            this.deletePswGroupBox.Size = new System.Drawing.Size(680, 241);
            this.deletePswGroupBox.TabIndex = 7;
            this.deletePswGroupBox.TabStop = false;
            this.deletePswGroupBox.Text = "Ištrinti slaptažodį";
            // 
            // DeletePassword
            // 
            this.DeletePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePassword.Location = new System.Drawing.Point(275, 185);
            this.DeletePassword.Name = "DeletePassword";
            this.DeletePassword.Size = new System.Drawing.Size(170, 29);
            this.DeletePassword.TabIndex = 6;
            this.DeletePassword.Text = "Ištrinti slaptažodį";
            this.DeletePassword.UseVisualStyleBackColor = true;
            // 
            // usernameToDeletePswTxt
            // 
            this.usernameToDeletePswTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameToDeletePswTxt.Location = new System.Drawing.Point(205, 54);
            this.usernameToDeletePswTxt.Name = "usernameToDeletePswTxt";
            this.usernameToDeletePswTxt.Size = new System.Drawing.Size(417, 22);
            this.usernameToDeletePswTxt.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(66, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Vartotojo Vardas:";
            // 
            // findPswGroupBox
            // 
            this.findPswGroupBox.Controls.Add(this.showPsw);
            this.findPswGroupBox.Controls.Add(this.ShowAllPswBtn);
            this.findPswGroupBox.Controls.Add(this.CopyPswBtn);
            this.findPswGroupBox.Controls.Add(this.dataGridView1);
            this.findPswGroupBox.Controls.Add(this.FindPswBtn2);
            this.findPswGroupBox.Controls.Add(this.findPswTxt);
            this.findPswGroupBox.Controls.Add(this.label9);
            this.findPswGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPswGroupBox.Location = new System.Drawing.Point(186, 12);
            this.findPswGroupBox.Name = "findPswGroupBox";
            this.findPswGroupBox.Size = new System.Drawing.Size(680, 241);
            this.findPswGroupBox.TabIndex = 8;
            this.findPswGroupBox.TabStop = false;
            this.findPswGroupBox.Text = "Rasti Slaptažodį";
            // 
            // CopyPswBtn
            // 
            this.CopyPswBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyPswBtn.Location = new System.Drawing.Point(589, 185);
            this.CopyPswBtn.Name = "CopyPswBtn";
            this.CopyPswBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CopyPswBtn.Size = new System.Drawing.Size(91, 56);
            this.CopyPswBtn.TabIndex = 9;
            this.CopyPswBtn.Text = "Nukopijuoti slaptažodį";
            this.CopyPswBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(15, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(568, 122);
            this.dataGridView1.TabIndex = 7;
            // 
            // FindPswBtn2
            // 
            this.FindPswBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindPswBtn2.Location = new System.Drawing.Point(269, 77);
            this.FindPswBtn2.Name = "FindPswBtn2";
            this.FindPswBtn2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FindPswBtn2.Size = new System.Drawing.Size(170, 29);
            this.FindPswBtn2.TabIndex = 6;
            this.FindPswBtn2.Text = "Rasti slaptažodį";
            this.FindPswBtn2.UseVisualStyleBackColor = true;
            this.FindPswBtn2.Click += new System.EventHandler(this.FindPswBtn2_Click);
            // 
            // findPswTxt
            // 
            this.findPswTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPswTxt.Location = new System.Drawing.Point(199, 36);
            this.findPswTxt.Name = "findPswTxt";
            this.findPswTxt.Size = new System.Drawing.Size(417, 22);
            this.findPswTxt.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Vartotojo Vardas:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Vartotojo Vardas";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 154;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Slaptažodis";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 117;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "URL/Aplikacija";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 137;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Komentarai";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 115;
            // 
            // ShowAllPswBtn
            // 
            this.ShowAllPswBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllPswBtn.Location = new System.Drawing.Point(589, 118);
            this.ShowAllPswBtn.Name = "ShowAllPswBtn";
            this.ShowAllPswBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowAllPswBtn.Size = new System.Drawing.Size(91, 61);
            this.ShowAllPswBtn.TabIndex = 10;
            this.ShowAllPswBtn.Text = "Parodyti visus slaptažodžius";
            this.ShowAllPswBtn.UseVisualStyleBackColor = true;
            // 
            // showPsw
            // 
            this.showPsw.AutoSize = true;
            this.showPsw.Location = new System.Drawing.Point(494, 88);
            this.showPsw.Name = "showPsw";
            this.showPsw.Size = new System.Drawing.Size(186, 24);
            this.showPsw.TabIndex = 57;
            this.showPsw.Text = "Parodyti slaptažodžius";
            this.showPsw.UseVisualStyleBackColor = true;
            this.showPsw.CheckedChanged += new System.EventHandler(this.showPsw_CheckedChanged);
            // 
            // PswManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 265);
            this.Controls.Add(this.findPswGroupBox);
            this.Controls.Add(this.DeletePswBtn);
            this.Controls.Add(this.FindPswBtn);
            this.Controls.Add(this.UpdatePswBtn);
            this.Controls.Add(this.NewPswBtn);
            this.Controls.Add(this.deletePswGroupBox);
            this.Controls.Add(this.updatePswGroupBox);
            this.Controls.Add(this.newPswGroupBox);
            this.Name = "PswManagerForm";
            this.Text = "PswManagerForm";
            this.newPswGroupBox.ResumeLayout(false);
            this.newPswGroupBox.PerformLayout();
            this.updatePswGroupBox.ResumeLayout(false);
            this.updatePswGroupBox.PerformLayout();
            this.deletePswGroupBox.ResumeLayout(false);
            this.deletePswGroupBox.PerformLayout();
            this.findPswGroupBox.ResumeLayout(false);
            this.findPswGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.GroupBox updatePswGroupBox;
        private System.Windows.Forms.Button UpdatePsw;
        private System.Windows.Forms.TextBox updateAdditionalInfoTxt;
        private System.Windows.Forms.TextBox updateURLtxt;
        private System.Windows.Forms.TextBox updatePswTxt;
        private System.Windows.Forms.TextBox updateUsernameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox deletePswGroupBox;
        private System.Windows.Forms.GroupBox findPswGroupBox;
        private System.Windows.Forms.Button CopyPswBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FindPswBtn2;
        private System.Windows.Forms.TextBox findPswTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DeletePassword;
        private System.Windows.Forms.TextBox usernameToDeletePswTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.CheckBox showPsw;
        private System.Windows.Forms.Button ShowAllPswBtn;
    }
}