﻿using System;
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
    public partial class FormFuturaInfoAdd : Form
    {
        public NpgsqlConnection con;

        public int id;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public FormFuturaInfoAdd(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Update()
        {
            String sql = "Select * from product";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            prodcomboBox.DataSource = dt;
            prodcomboBox.DisplayMember = "prod_name";
            prodcomboBox.ValueMember = "id_product";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormFuturaInfoAdd_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(
"INSERT INTO futura_info (id_futura,id_product,quantity,price,payment) VALUES(:idfutura,:idproduct,:quantity,:price,:payment)", con);
            cmd.Parameters.AddWithValue("idproduct", prodcomboBox.SelectedValue);
            cmd.Parameters.AddWithValue("quantity", Convert.ToDouble(textBoxQan.Text));
            cmd.Parameters.AddWithValue("price", Convert.ToDouble(textBoxPr.Text));
            if (checkBox1.Checked == true)
            {
                cmd.Parameters.AddWithValue("payment", "True");
            }
            else
            {
                cmd.Parameters.AddWithValue("payment", "False");
            }
            cmd.ExecuteNonQuery();
            Close();

        }
    }
}
