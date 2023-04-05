namespace Poject_lab
{
    partial class Allstd
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
            dataGridView1 = new DataGridView();
            i = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            B = new DataGridViewTextBoxColumn();
            Load = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { i, Age, B });
            dataGridView1.Location = new Point(4, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(428, 398);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // i
            // 
            i.HeaderText = "ID";
            i.MinimumWidth = 6;
            i.Name = "i";
            i.Width = 125;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            Age.Width = 125;
            // 
            // B
            // 
            B.HeaderText = "Branch";
            B.MinimumWidth = 6;
            B.Name = "B";
            B.Width = 125;
            // 
            // Load
            // 
            Load.Location = new Point(4, 0);
            Load.Name = "Load";
            Load.Size = new Size(428, 37);
            Load.TabIndex = 1;
            Load.Text = "Load";
            Load.UseVisualStyleBackColor = true;
            Load.Click += Load_Click;
            // 
            // Allstd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 434);
            Controls.Add(Load);
            Controls.Add(dataGridView1);
            Name = "Allstd";
            Text = "Allstd";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Load;
        private DataGridViewTextBoxColumn i;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn B;
    }
}