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
            this.prodcomboBox = new System.Windows.Forms.ComboBox();
            this.textBoxQan = new System.Windows.Forms.TextBox();
            this.textBoxPr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prodcomboBox
            // 
            this.prodcomboBox.FormattingEnabled = true;
            this.prodcomboBox.Location = new System.Drawing.Point(25, 36);
            this.prodcomboBox.Name = "prodcomboBox";
            this.prodcomboBox.Size = new System.Drawing.Size(214, 23);
            this.prodcomboBox.TabIndex = 0;
            // 
            // textBoxQan
            // 
            this.textBoxQan.Location = new System.Drawing.Point(25, 95);
            this.textBoxQan.Name = "textBoxQan";
            this.textBoxQan.Size = new System.Drawing.Size(214, 23);
            this.textBoxQan.TabIndex = 1;
            // 
            // textBoxPr
            // 
            this.textBoxPr.Location = new System.Drawing.Point(25, 151);
            this.textBoxPr.Name = "textBoxPr";
            this.textBoxPr.Size = new System.Drawing.Size(214, 23);
            this.textBoxPr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Товары";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(285, 36);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 6;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(285, 65);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 7;
            this.close_button.Text = "Закрыть";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormFuturaInfoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 535);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPr);
            this.Controls.Add(this.textBoxQan);
            this.Controls.Add(this.prodcomboBox);
            this.Name = "FormFuturaInfoAdd";
            this.Text = "FormFuturaInfoAdd";
            this.Load += new System.EventHandler(this.FormFuturaInfoAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}