namespace DecanatPRO.WinFormsView
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridViewStudents = new DataGridView();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonChart = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.AllowUserToDeleteRows = false;
            dataGridViewStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.BackgroundColor = Color.LavenderBlush;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.GridColor = Color.MistyRose;
            dataGridViewStudents.Location = new Point(20, 24);
            dataGridViewStudents.Margin = new Padding(5, 6, 5, 6);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.ReadOnly = true;
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudents.Size = new Size(1261, 634);
            dataGridViewStudents.TabIndex = 0;
            dataGridViewStudents.CellContentClick += dataGridViewStudents_CellContentClick;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAdd.BackColor = Color.LavenderBlush;
            buttonAdd.FlatAppearance.BorderColor = Color.HotPink;
            buttonAdd.FlatAppearance.BorderSize = 4;
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Evolventa", 12F, FontStyle.Bold);
            buttonAdd.Location = new Point(20, 714);
            buttonAdd.Margin = new Padding(5, 6, 5, 6);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(244, 80);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDelete.BackColor = Color.LavenderBlush;
            buttonDelete.FlatAppearance.BorderColor = Color.HotPink;
            buttonDelete.FlatAppearance.BorderSize = 4;
            buttonDelete.FlatStyle = FlatStyle.Popup;
            buttonDelete.Font = new Font("Evolventa", 12F, FontStyle.Bold);
            buttonDelete.Location = new Point(291, 714);
            buttonDelete.Margin = new Padding(5, 6, 5, 6);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(244, 80);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonChart
            // 
            buttonChart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonChart.BackColor = Color.LavenderBlush;
            buttonChart.FlatAppearance.BorderColor = Color.HotPink;
            buttonChart.FlatAppearance.BorderSize = 4;
            buttonChart.FlatStyle = FlatStyle.Popup;
            buttonChart.Font = new Font("Evolventa", 11F, FontStyle.Bold);
            buttonChart.Location = new Point(556, 714);
            buttonChart.Margin = new Padding(5, 6, 5, 6);
            buttonChart.Name = "buttonChart";
            buttonChart.Size = new Size(244, 80);
            buttonChart.TabIndex = 3;
            buttonChart.Text = "Гистограмма";
            buttonChart.UseVisualStyleBackColor = false;
            buttonChart.Click += buttonChart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1300, 834);
            Controls.Add(buttonChart);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewStudents);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Деканат PRO - Список студентов";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChart;
    }
}