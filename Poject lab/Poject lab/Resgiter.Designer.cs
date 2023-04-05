namespace Poject_lab
{
    partial class Resgiter
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
            label1 = new Label();
            iusername = new TextBox();
            ipassword = new TextBox();
            iID = new TextBox();
            idate = new TextBox();
            iage = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            iBranch = new TextBox();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("STHupo", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(221, 48);
            label1.Name = "label1";
            label1.Size = new Size(144, 45);
            label1.TabIndex = 0;
            label1.Text = "สมัครสอบ";
            label1.Click += label1_Click;
            // 
            // iusername
            // 
            iusername.Location = new Point(166, 115);
            iusername.Multiline = true;
            iusername.Name = "iusername";
            iusername.Size = new Size(250, 33);
            iusername.TabIndex = 1;
            // 
            // ipassword
            // 
            ipassword.Location = new Point(166, 172);
            ipassword.Multiline = true;
            ipassword.Name = "ipassword";
            ipassword.Size = new Size(250, 33);
            ipassword.TabIndex = 2;
            // 
            // iID
            // 
            iID.Location = new Point(166, 231);
            iID.Multiline = true;
            iID.Name = "iID";
            iID.Size = new Size(250, 33);
            iID.TabIndex = 3;
            // 
            // idate
            // 
            idate.Location = new Point(166, 287);
            idate.Multiline = true;
            idate.Name = "idate";
            idate.Size = new Size(250, 33);
            idate.TabIndex = 4;
            idate.TextChanged += idate_TextChanged;
            // 
            // iage
            // 
            iage.Location = new Point(166, 343);
            iage.Multiline = true;
            iage.Name = "iage";
            iage.Size = new Size(250, 33);
            iage.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(200, 453);
            button1.Name = "button1";
            button1.Size = new Size(181, 41);
            button1.TabIndex = 6;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 115);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(57, 172);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 292);
            label5.Name = "label5";
            label5.Size = new Size(128, 28);
            label5.TabIndex = 10;
            label5.Text = "วัน/เดือน/ปีเกิด";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(108, 343);
            label6.Name = "label6";
            label6.Size = new Size(42, 28);
            label6.TabIndex = 11;
            label6.Text = "อายุ";
            // 
            // iBranch
            // 
            iBranch.Location = new Point(166, 400);
            iBranch.Multiline = true;
            iBranch.Name = "iBranch";
            iBranch.Size = new Size(250, 33);
            iBranch.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(97, 405);
            label7.Name = "label7";
            label7.Size = new Size(53, 28);
            label7.TabIndex = 14;
            label7.Text = "สาขา";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(39, 231);
            label8.Name = "label8";
            label8.Size = new Size(111, 28);
            label8.TabIndex = 15;
            label8.Text = "รหัสนักศึกษา";
            // 
            // Resgiter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 558);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(iBranch);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(iage);
            Controls.Add(idate);
            Controls.Add(iID);
            Controls.Add(ipassword);
            Controls.Add(iusername);
            Controls.Add(label1);
            Name = "Resgiter";
            Text = "Resgiter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox iusername;
        private TextBox ipassword;
        private TextBox iID;
        private TextBox idate;
        private TextBox iage;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox iBranch;
        private Label label7;
        private Label label8;
    }
}