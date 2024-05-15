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
            menuStrip1 = new MenuStrip();
            StripMenu_Items = new ToolStripMenuItem();
            StripMenu_Clients = new ToolStripMenuItem();
            StripMenu_Overhead = new ToolStripMenuItem();
            StripMenu_Report = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { StripMenu_Items, StripMenu_Clients, StripMenu_Overhead, StripMenu_Report });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(873, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Меню";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // StripMenu_Items
            // 
            StripMenu_Items.Name = "StripMenu_Items";
            StripMenu_Items.Size = new Size(60, 20);
            StripMenu_Items.Text = "Товары";
            StripMenu_Items.Click += StripMenu_Items_Click;
            // 
            // StripMenu_Clients
            // 
            StripMenu_Clients.Name = "StripMenu_Clients";
            StripMenu_Clients.Size = new Size(67, 20);
            StripMenu_Clients.Text = "Клиенты";
            StripMenu_Clients.Click += StripMenu_Clients_Click;
            // 
            // StripMenu_Overhead
            // 
            StripMenu_Overhead.Name = "StripMenu_Overhead";
            StripMenu_Overhead.Size = new Size(81, 20);
            StripMenu_Overhead.Text = "Накладные";
            StripMenu_Overhead.Click += StripMenu_Overhead_Click;
            // 
            // StripMenu_Report
            // 
            StripMenu_Report.Name = "StripMenu_Report";
            StripMenu_Report.Size = new Size(60, 20);
            StripMenu_Report.Text = "Отчеты";
            StripMenu_Report.Click += StripMenu_Report_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 536);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem StripMenu_Items;
        private ToolStripMenuItem StripMenu_Clients;
        private ToolStripMenuItem StripMenu_Overhead;
        private ToolStripMenuItem StripMenu_Report;
    }
}