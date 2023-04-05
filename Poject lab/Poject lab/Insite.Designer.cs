namespace Poject_lab
{
    partial class Insite
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
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            AllstdexamToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Image = Properties.Resources.E177ydyVoAEml4u;
            label1.Location = new Point(85, 9);
            label1.Name = "label1";
            label1.Size = new Size(458, 59);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Exam";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(615, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(615, 28);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AllstdexamToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // AllstdexamToolStripMenuItem
            // 
            AllstdexamToolStripMenuItem.Name = "AllstdexamToolStripMenuItem";
            AllstdexamToolStripMenuItem.Size = new Size(224, 26);
            AllstdexamToolStripMenuItem.Text = "รายชื่อผู้สมัครสอบ";
            AllstdexamToolStripMenuItem.Click += AllstdexamToolStripMenuItem_Click;
            // 
            // Insite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mc_meme_overwatch;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(615, 424);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Insite";
            Text = "Insite";
            Load += Insite_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem AllstdexamToolStripMenuItem;
    }
}