namespace WinFormsApp2
{
    partial class Form2
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
            label2 = new Label();
            label3 = new Label();
            textBoxForm2Name = new TextBox();
            textBoxForm2Count = new TextBox();
            textBoxForm2Category = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 70);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Количество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 110);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Категория";
            // 
            // textBoxForm2Name
            // 
            textBoxForm2Name.Location = new Point(127, 29);
            textBoxForm2Name.Name = "textBoxForm2Name";
            textBoxForm2Name.Size = new Size(125, 27);
            textBoxForm2Name.TabIndex = 3;
            textBoxForm2Name.TextChanged += textBoxForm2Name_TextChanged;
            // 
            // textBoxForm2Count
            // 
            textBoxForm2Count.Location = new Point(126, 70);
            textBoxForm2Count.Name = "textBoxForm2Count";
            textBoxForm2Count.Size = new Size(125, 27);
            textBoxForm2Count.TabIndex = 4;
            // 
            // textBoxForm2Category
            // 
            textBoxForm2Category.Location = new Point(127, 110);
            textBoxForm2Category.Name = "textBoxForm2Category";
            textBoxForm2Category.Size = new Size(125, 27);
            textBoxForm2Category.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(12, 183);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Отмена\r\n";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            button2.Location = new Point(240, 183);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 226);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxForm2Category);
            Controls.Add(textBoxForm2Count);
            Controls.Add(textBoxForm2Name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox textBoxForm2Name;
        public TextBox textBoxForm2Count;
        public TextBox textBoxForm2Category;
        private Button button1;
        private Button button2;
    }
}