namespace DecanatPRO.WinFormsView
{
    partial class AddStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            textBoxSpeciality = new TextBox();
            textBoxGroup = new TextBox();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Pink;
            label1.Font = new Font("Evolventa", 14F);
            label1.Location = new Point(53, 104);
            label1.Name = "label1";
            label1.Size = new Size(114, 51);
            label1.TabIndex = 0;
            label1.Text = "ФИО";
            label1.Click += label1_Click;
            label1.Paint += label1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Pink;
            label2.Font = new Font("Evolventa", 14F);
            label2.Location = new Point(53, 289);
            label2.Name = "label2";
            label2.Size = new Size(314, 51);
            label2.TabIndex = 1;
            label2.Text = "специальность";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Evolventa", 14F);
            label3.Location = new Point(53, 474);
            label3.Name = "label3";
            label3.Size = new Size(152, 51);
            label3.TabIndex = 2;
            label3.Text = "группа";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.LavenderBlush;
            textBoxName.Location = new Point(53, 170);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(215, 39);
            textBoxName.TabIndex = 3;
            // 
            // textBoxSpeciality
            // 
            textBoxSpeciality.BackColor = Color.LavenderBlush;
            textBoxSpeciality.Location = new Point(53, 358);
            textBoxSpeciality.Name = "textBoxSpeciality";
            textBoxSpeciality.Size = new Size(215, 39);
            textBoxSpeciality.TabIndex = 4;
            // 
            // textBoxGroup
            // 
            textBoxGroup.BackColor = Color.LavenderBlush;
            textBoxGroup.Location = new Point(53, 550);
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.Size = new Size(215, 39);
            textBoxGroup.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LavenderBlush;
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Font = new Font("Evolventa", 16F);
            buttonSave.ForeColor = Color.LightPink;
            buttonSave.Location = new Point(117, 631);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(282, 93);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(516, 801);
            Controls.Add(buttonSave);
            Controls.Add(textBoxGroup);
            Controls.Add(textBoxSpeciality);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Arrow;
            Font = new Font("Evolventa", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxSpeciality;
        private TextBox textBoxGroup;
        private Button buttonSave;
    }
}