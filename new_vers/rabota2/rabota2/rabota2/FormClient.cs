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
    public partial class FormClient : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public void Update()
        {
            String sql = "Select * from client";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView2.DataSource = dt;
            dataGridView2.Columns[0].HeaderText = "Номер";
            dataGridView2.Columns[1].HeaderText = "Наименование";
            dataGridView2.Columns[2].HeaderText = "Номер телефона";
            dataGridView2.Columns[3].HeaderText = "Адрес";
            StartPosition = FormStartPosition.CenterScreen;
        }
        public FormClient(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            Update();
        }

        private void StripMenu_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StripMenu_Add_Click(object sender, EventArgs e)
        {
            FormClientAdd fca=new FormClientAdd(con);
            
            fca.ShowDialog();
            Update();
        }

        private void StripMenu_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Точно хотите удалить?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    int id = (int)dataGridView2.CurrentRow.Cells["id"].Value;
                    NpgsqlCommand command = new NpgsqlCommand("delete from client where id= :id", con);
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                    Update();
                }
                if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Не удаляем!");
                }
            }
            catch
            {
                MessageBox.Show("Тут пусто!");
            }
        }

        private void StripMenu_Change_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView2.CurrentRow.Cells["id"].Value;
            string name = (string)dataGridView2.CurrentRow.Cells["name"].Value;
            string phone = (string)dataGridView2.CurrentRow.Cells["phone"].Value;
            string adres = (string)dataGridView2.CurrentRow.Cells["adress"].Value;
            FormClientAdd fca = new FormClientAdd(con, id, name, phone,adres);
            fca.ShowDialog();
            Update();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            Update();
        }
    }
}
