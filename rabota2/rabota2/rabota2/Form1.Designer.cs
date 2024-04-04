namespace rabota2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripMenu_Items = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_Clients = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_Overhead = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu_Items,
            this.StripMenu_Clients,
            this.StripMenu_Overhead,
            this.StripMenu_Report});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Меню";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // StripMenu_Items
            // 
            this.StripMenu_Items.Name = "StripMenu_Items";
            this.StripMenu_Items.Size = new System.Drawing.Size(60, 20);
            this.StripMenu_Items.Text = "Товары";
            this.StripMenu_Items.Click += new System.EventHandler(this.StripMenu_Items_Click);
            // 
            // StripMenu_Clients
            // 
            this.StripMenu_Clients.Name = "StripMenu_Clients";
            this.StripMenu_Clients.Size = new System.Drawing.Size(67, 20);
            this.StripMenu_Clients.Text = "Клиенты";
           
            // 
            // StripMenu_Overhead
            // 
            this.StripMenu_Overhead.Name = "StripMenu_Overhead";
            this.StripMenu_Overhead.Size = new System.Drawing.Size(81, 20);
            this.StripMenu_Overhead.Text = "Накладные";
            // 
            // StripMenu_Report
            // 
            this.StripMenu_Report.Name = "StripMenu_Report";
            this.StripMenu_Report.Size = new System.Drawing.Size(60, 20);
            this.StripMenu_Report.Text = "Отчеты";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 536);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem StripMenu_Items;
        private ToolStripMenuItem StripMenu_Clients;
        private ToolStripMenuItem StripMenu_Overhead;
        private ToolStripMenuItem StripMenu_Report;
    }
}