using Npgsql;
namespace rabota2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            
            InitializeComponent();
           
        }
        public NpgsqlConnection con;
        public void MyLoad()
        {
            StartPosition = FormStartPosition.CenterScreen;
            con = new NpgsqlConnection("Server=localhost;Port=5432;UserID=postgres;Password=postpass;Database=KabaevDatabase");
            con.Open();

        }
        
       

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            MyLoad();
        }

        private void StripMenu_Items_Click(object sender, EventArgs e)
        {
            FormProduct fp = new FormProduct(con);
            fp.ShowDialog();
        }

        private void StripMenu_Overhead_Click(object sender, EventArgs e)
        {
            Form_futura ff=new Form_futura(con);
            ff.ShowDialog();
        }

        private void StripMenu_Clients_Click(object sender, EventArgs e)
        {
            FormClient fc = new FormClient(con);
            fc.ShowDialog();

        }
    }
}