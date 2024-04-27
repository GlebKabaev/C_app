using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace rabota2
{
    public partial class FormProduct : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public void Update()
        {
            String sql = "Select * from product";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt=ds.Tables[0];
            dataGridView.DataSource=dt;
            dataGridView.Columns[0].HeaderText = "Номер";
            dataGridView.Columns[1].HeaderText = "Наименование";
            dataGridView.Columns[2].HeaderText = "Ед.Измерения";
            StartPosition = FormStartPosition.CenterScreen;
        }
        public FormProduct(NpgsqlConnection con)
        {
            
            InitializeComponent();
            this.con = con;
        }

        private void StripMenu_Exit_Click(object sender, EventArgs e)
        {
            Close();
           
        }

        private void StripMenu_Add_Click(object sender, EventArgs e)
        {
            Form_add form_Add = new Form_add(con);
            form_Add.ShowDialog();
            Update();
        }
        
        private void StripMenu_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Точно хотите удалить?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                { 
                    int id = (int)dataGridView.CurrentRow.Cells["id_product"].Value;
                    NpgsqlCommand command = new NpgsqlCommand("delete from product where id_product= :id", con);
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                    Update();
                }
                if  (res== DialogResult.Cancel)
                {
                    MessageBox.Show("Не удаляем!");
                }
            }
            catch {
                MessageBox.Show("Тут пусто!");
            }
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void StripMenu_Change_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView.CurrentRow.Cells["id_product"].Value;
            string name= (string)dataGridView.CurrentRow.Cells["prod_name"].Value;
            string ed = (string)dataGridView.CurrentRow.Cells["ed"].Value;
            Form_add form_Add = new Form_add(con,id,name,ed);
            form_Add.ShowDialog();
            Update();
        }
    }
}
