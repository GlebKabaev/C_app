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
    public partial class FuturaFormAdd : Form
    {
        public NpgsqlConnection con;
        public int id;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public FuturaFormAdd(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            
            
        }
        public void Update()
        {
            String sql = "Select * from client";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            comboBoxClient.DataSource = dt;
            comboBoxClient.DisplayMember = "name";
            comboBoxClient.ValueMember="ID";
        }

        private void FuturaFormAdd_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
           
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO futura (idclient,data,totalsum)" + "VALUES(:idclient,:data,0)",con);
                DateTime dt1 = this.dateTimePicker1.Value.Date;
                cmd.Parameters.AddWithValue("idclient", comboBoxClient.SelectedValue);
                cmd.Parameters.AddWithValue("data", dt1);
                cmd.ExecuteNonQuery();
                Close();
               
                
            
            
        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
