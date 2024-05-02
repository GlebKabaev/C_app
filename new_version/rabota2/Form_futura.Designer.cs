namespace rabota2
{
    partial class Form_futura
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.futuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.futurainfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FuturaDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.FuturaInfoDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1555, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.futuraToolStripMenuItem,
            this.futurainfoToolStripMenuItem});
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // futuraToolStripMenuItem
            // 
            this.futuraToolStripMenuItem.Name = "futuraToolStripMenuItem";
            this.futuraToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.futuraToolStripMenuItem.Text = "Futura";
            this.futuraToolStripMenuItem.Click += new System.EventHandler(this.futuraToolStripMenuItem_Click);
            // 
            // futurainfoToolStripMenuItem
            // 
            this.futurainfoToolStripMenuItem.Name = "futurainfoToolStripMenuItem";
            this.futurainfoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.futurainfoToolStripMenuItem.Text = "Futurainfo";
            this.futurainfoToolStripMenuItem.Click += new System.EventHandler(this.futurainfoToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FuturaDelete,
            this.FuturaInfoDelete});
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.DeleteToolStripMenuItem.Text = "Удалиь";
            // 
            // FuturaDelete
            // 
            this.FuturaDelete.Name = "FuturaDelete";
            this.FuturaDelete.Size = new System.Drawing.Size(180, 22);
            this.FuturaDelete.Text = "Futura";
            this.FuturaDelete.Click += new System.EventHandler(this.FuturaDelete_Click);
            // 
            // FuturaInfoDelete
            // 
            this.FuturaInfoDelete.Name = "FuturaInfoDelete";
            this.FuturaInfoDelete.Size = new System.Drawing.Size(180, 22);
            this.FuturaInfoDelete.Text = "FuturaInfo";
            this.FuturaInfoDelete.Click += new System.EventHandler(this.FuturaInfoDelete_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 420);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(861, 149);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(636, 420);
            this.dataGridView2.TabIndex = 2;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(742, 611);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 3;
            this.update.Text = "обновить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Form_futura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 663);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_futura";
            this.Text = "Form_futura";
            this.Load += new System.EventHandler(this.Form_futura_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem AddToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private ToolStripMenuItem futuraToolStripMenuItem;
        private ToolStripMenuItem futurainfoToolStripMenuItem;
        private Button update;
        private ToolStripMenuItem FuturaDelete;
        private ToolStripMenuItem FuturaInfoDelete;
    }
}