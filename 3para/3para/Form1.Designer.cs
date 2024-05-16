namespace _3para
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.ComboBox();
            this.Radio_Sex_Male = new System.Windows.Forms.RadioButton();
            this.Radio_sex_female = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.checkedListBoxSport = new System.Windows.Forms.CheckedListBox();
            this.button_accept = new System.Windows.Forms.Button();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Excel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ф И О ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Город";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пол";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // City
            // 
            this.City.BackColor = System.Drawing.Color.Thistle;
            this.City.FormattingEnabled = true;
            this.City.Items.AddRange(new object[] {
            "Москва",
            "Не москва"});
            this.City.Location = new System.Drawing.Point(149, 88);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(182, 23);
            this.City.TabIndex = 4;
            // 
            // Radio_Sex_Male
            // 
            this.Radio_Sex_Male.AutoSize = true;
            this.Radio_Sex_Male.Location = new System.Drawing.Point(149, 117);
            this.Radio_Sex_Male.Name = "Radio_Sex_Male";
            this.Radio_Sex_Male.Size = new System.Drawing.Size(36, 19);
            this.Radio_Sex_Male.TabIndex = 5;
            this.Radio_Sex_Male.TabStop = true;
            this.Radio_Sex_Male.Text = "М";
            this.Radio_Sex_Male.UseVisualStyleBackColor = true;
            // 
            // Radio_sex_female
            // 
            this.Radio_sex_female.AutoSize = true;
            this.Radio_sex_female.Location = new System.Drawing.Point(191, 117);
            this.Radio_sex_female.Name = "Radio_sex_female";
            this.Radio_sex_female.Size = new System.Drawing.Size(36, 19);
            this.Radio_sex_female.TabIndex = 6;
            this.Radio_sex_female.TabStop = true;
            this.Radio_sex_female.Text = "Ж";
            this.Radio_sex_female.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Спорт Секции";
            // 
            // TextName
            // 
            this.TextName.BackColor = System.Drawing.Color.Thistle;
            this.TextName.Location = new System.Drawing.Point(149, 59);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(277, 23);
            this.TextName.TabIndex = 8;
            // 
            // checkedListBoxSport
            // 
            this.checkedListBoxSport.BackColor = System.Drawing.Color.Thistle;
            this.checkedListBoxSport.FormattingEnabled = true;
            this.checkedListBoxSport.Items.AddRange(new object[] {
            "Бокс",
            "Карате",
            "Плаванье",
            "Бег"});
            this.checkedListBoxSport.Location = new System.Drawing.Point(194, 140);
            this.checkedListBoxSport.Name = "checkedListBoxSport";
            this.checkedListBoxSport.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxSport.TabIndex = 9;
            this.checkedListBoxSport.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxSport_SelectedIndexChanged);
            // 
            // button_accept
            // 
            this.button_accept.Location = new System.Drawing.Point(194, 240);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(85, 23);
            this.button_accept.TabIndex = 10;
            this.button_accept.Text = "Подтвердить";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.BackColor = System.Drawing.Color.Thistle;
            this.richTextBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfo.Location = new System.Drawing.Point(451, 88);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(315, 295);
            this.richTextBoxInfo.TabIndex = 11;
            this.richTextBoxInfo.Text = "";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.Thistle;
            this.dateTimePicker.Location = new System.Drawing.Point(577, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 12;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // Excel_Button
            // 
            this.Excel_Button.Location = new System.Drawing.Point(194, 297);
            this.Excel_Button.Name = "Excel_Button";
            this.Excel_Button.Size = new System.Drawing.Size(85, 23);
            this.Excel_Button.TabIndex = 13;
            this.Excel_Button.Text = "Выгрузить";
            this.Excel_Button.UseVisualStyleBackColor = true;
            this.Excel_Button.Click += new System.EventHandler(this.Excel_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Excel_Button);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.checkedListBoxSport);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Radio_sex_female);
            this.Controls.Add(this.Radio_Sex_Male);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox City;
        private RadioButton Radio_Sex_Male;
        private RadioButton Radio_sex_female;
        private Label label5;
        private TextBox TextName;
        private CheckedListBox checkedListBoxSport;
        private Button button_accept;
        private RichTextBox richTextBoxInfo;
        private DateTimePicker dateTimePicker;
        private Button Excel_Button;
    }
}