namespace rabota2
{
    partial class FormProduct
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripMenu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_Change = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu_Add,
            this.StripMenu_Change,
            this.StripMenu_Delete,
            this.StripMenu_Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripMenu_Add
            // 
            this.StripMenu_Add.Name = "StripMenu_Add";
            this.StripMenu_Add.Size = new System.Drawing.Size(74, 20);
            this.StripMenu_Add.Text = "Добавить ";
            // 
            // StripMenu_Change
            // 
            this.StripMenu_Change.Name = "StripMenu_Change";
            this.StripMenu_Change.Size = new System.Drawing.Size(73, 20);
            this.StripMenu_Change.Text = "Изменить";
            // 
            // StripMenu_Delete
            // 
            this.StripMenu_Delete.Name = "StripMenu_Delete";
            this.StripMenu_Delete.Size = new System.Drawing.Size(63, 20);
            this.StripMenu_Delete.Text = "Удалить";
            // 
            // StripMenu_Exit
            // 
            this.StripMenu_Exit.Name = "StripMenu_Exit";
            this.StripMenu_Exit.Size = new System.Drawing.Size(54, 20);
            this.StripMenu_Exit.Text = "Выход";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem StripMenu_Add;
        private ToolStripMenuItem StripMenu_Change;
        private ToolStripMenuItem StripMenu_Delete;
        private ToolStripMenuItem StripMenu_Exit;
    }
}