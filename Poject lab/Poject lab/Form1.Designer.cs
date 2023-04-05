namespace Poject_lab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            Signin = new Button();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            Resgiter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("STHupo", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(124, 49);
            label1.Name = "label1";
            label1.Size = new Size(213, 45);
            label1.TabIndex = 0;
            label1.Text = "ล็อกอินเพื่อสอบ";
            label1.Click += label1_Click;
            // 
            // Signin
            // 
            Signin.Location = new Point(110, 244);
            Signin.Name = "Signin";
            Signin.Size = new Size(103, 39);
            Signin.TabIndex = 1;
            Signin.Text = "Sign in";
            Signin.UseVisualStyleBackColor = true;
            Signin.Click += Signin_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(110, 125);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(241, 30);
            tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(110, 182);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(241, 30);
            tbPassword.TabIndex = 3;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // Resgiter
            // 
            Resgiter.Location = new Point(248, 244);
            Resgiter.Name = "Resgiter";
            Resgiter.Size = new Size(103, 39);
            Resgiter.TabIndex = 4;
            Resgiter.Text = "Resgiter";
            Resgiter.UseVisualStyleBackColor = true;
            Resgiter.Click += Resgiter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(449, 368);
            Controls.Add(Resgiter);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(Signin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Home";
            TransparencyKey = SystemColors.ActiveBorder;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Signin;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button Resgiter;
    }
}