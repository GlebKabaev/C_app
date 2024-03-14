using Npgsql;
namespace rabota2
{
    public partial class Form1 : Form
    {
        public NpgsqlConnection con;
        public void MyLoad()
        {
            StartPosition = FormStartPosition.CenterScreen;
            con = new NpgsqlConnection("Server=localhost;Port=5432;UserID=postgers;Password=postpass;Database=MyBase");
            con.Open();
        }
        
        public Form1(NpgsqlConnection con)
        {
            
            InitializeComponent();
            this.con = con;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyLoad();
        }
    }
}