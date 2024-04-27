namespace rabota2
{
    partial class FormFuturaInfoAdd
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
            prodcomboBox = new ComboBox();
            textBoxQan = new TextBox();
            textBoxPr = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            add_button = new Button();
            close_button = new Button();
            checkBox1 = new CheckBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // prodcomboBox
            // 
            prodcomboBox.FormattingEnabled = true;
            prodcomboBox.Location = new Point(25, 36);
            prodcomboBox.Name = "prodcomboBox";
            prodcomboBox.Size = new Size(214, 23);
            prodcomboBox.TabIndex = 0;
            // 
            // textBoxQan
            // 
            textBoxQan.Location = new Point(25, 95);
            textBoxQan.Name = "textBoxQan";
            textBoxQan.Size = new Size(214, 23);
            textBoxQan.TabIndex = 1;
            // 
            // textBoxPr
            // 
            textBoxPr.Location = new Point(25, 151);
            textBoxPr.Name = "textBoxPr";
            textBoxPr.Size = new Size(214, 23);
            textBoxPr.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 3;
            label1.Text = "Товары";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 77);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Количество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 133);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "Цена";
            // 
            // add_button
            // 
            add_button.Location = new Point(285, 36);
            add_button.Name = "add_button";
            add_button.Size = new Size(75, 23);
            add_button.TabIndex = 6;
            add_button.Text = "Добавить";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += button1_Click;
            // 
            // close_button
            // 
            close_button.Location = new Point(285, 65);
            close_button.Name = "close_button";
            close_button.Size = new Size(75, 23);
            close_button.TabIndex = 7;
            close_button.Text = "Закрыть";
            close_button.UseVisualStyleBackColor = true;
            close_button.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(25, 208);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(40, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Да";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 190);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 9;
            label4.Text = "Оплачен?";
            // 
            // FormFuturaInfoAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 535);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(close_button);
            Controls.Add(add_button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPr);
            Controls.Add(textBoxQan);
            Controls.Add(prodcomboBox);
            Name = "FormFuturaInfoAdd";
            Text = "FormFuturaInfoAdd";
            Load += FormFuturaInfoAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox prodcomboBox;
        private TextBox textBoxQan;
        private TextBox textBoxPr;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button add_button;
        private Button close_button;
        private CheckBox checkBox1;
        private Label label4;
    }
}