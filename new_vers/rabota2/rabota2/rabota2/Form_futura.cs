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
    public partial class Form_futura : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public Form_futura(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Update1()
        {
            String sql = "Select * from futura";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Клиент";
            dataGridView1.Columns[2].HeaderText = "Дата";
            dataGridView1.Columns[3].HeaderText = "Итоговая сумма";
            StartPosition = FormStartPosition.CenterScreen;
        }
        public void Update2()
        {
            String sql = "Select * from futurainfo";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView2.DataSource = dt;
            dataGridView2.Columns[0].HeaderText = "Номер";
            dataGridView2.Columns[1].HeaderText = "Наименование";
            dataGridView2.Columns[2].HeaderText = "Количество";
            dataGridView2.Columns[3].HeaderText = "Цена";
            dataGridView2.Columns[4].HeaderText = "Продукт";
            StartPosition = FormStartPosition.CenterScreen;

        }
        

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void futuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuturaFormAdd ffa=new FuturaFormAdd(con);
            ffa.ShowDialog();
            Update1();
            
        }

        private void futurainfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuturaInfoAdd ffia = new FormFuturaInfoAdd(con,(int)dataGridView1.CurrentCell.Value);
            ffia.ShowDialog();
        }

        private void Form_futura_Load(object sender, EventArgs e)
        {
            Update1();
            Update2();
           
        }

        private void update_Click(object sender, EventArgs e)
        {
            Update1();
            Update2();
        }

        private void futuraToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void FuturaDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Точно хотите удалить?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
                    NpgsqlCommand command = new NpgsqlCommand("delete from futura where id= :id", con);
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                    Update1();
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

        private void FuturaInfoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Точно хотите удалить?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    int id = (int)dataGridView2.CurrentRow.Cells["id"].Value;
                    NpgsqlCommand command = new NpgsqlCommand("delete from futurainfo where id= :id", con);
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                    Update1();
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
    }
}
