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
    public partial class FormFuturaInfoAdd : Form
    {
        public NpgsqlConnection con;
        public FormFuturaInfoAdd(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
