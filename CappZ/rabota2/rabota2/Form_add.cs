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
    public partial class Form_add : Form
    {
        public NpgsqlConnection con;
        public int id;
        public Form_add(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            id = -1;
        }
        public Form_add(NpgsqlConnection con,int id,string name,string ed)
        {
            InitializeComponent();
            this.con = con;
            this.id = id;
            textBoxName.Text = name;
            textBoxEd.Text = ed;   

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand
                        ("INSERT INTO product (prod_name,ed) VALUES (:name, :ed)", con);
                    command.Parameters.AddWithValue("ed", textBoxEd.Text);
                    command.Parameters.AddWithValue("name", textBoxName.Text);
                    command.ExecuteNonQuery();
                    Close();
                }
                catch { }
            }
            else
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand
                        ("Update product SET (prod_name,ed) = (:name, :ed) WHERE id_product=:id ", con);
                command.Parameters.AddWithValue("ed", textBoxEd.Text);
                command.Parameters.AddWithValue("name", textBoxName.Text);
                command.Parameters.AddWithValue("id",id);
                command.ExecuteNonQuery();
                
                }
                catch { }
            }
        }
        
    }
}
