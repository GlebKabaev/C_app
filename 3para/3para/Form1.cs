using Microsoft.Office.Interop.Excel;
namespace _3para
{

    public partial class Form1 : Form
    {
        List<User> users = new List<User>();

        public Form1()
        {
            users=new List<User>();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void button_accept_Click(object sender, EventArgs e)
        { string sex = "";
            string sport = "";
            richTextBoxInfo.Clear();
            String Information = "Результаты сохранены\n";
            Information += TextName.Text + "\n";
            Information += City.Text + "\n";
            Information += dateTimePicker.Text + "\n";
            if (Radio_Sex_Male.Checked) { Information += "Пол мужской \n"; sex = "мужской"; }
            if (Radio_sex_female.Checked) { Information += "Пол женский \n"; sex = "женский"; }
            for (int i = 0; i < checkedListBoxSport.CheckedItems.Count; i++)
            {
                Information += checkedListBoxSport.CheckedItems[i] + "\n";
                sport += checkedListBoxSport.CheckedItems[i] +"   ";
            }
            richTextBoxInfo.AppendText(Information);
            User users1 = new User(TextName.Text, City.Text,sport ,sex);
            users.Add(users1);
        }

        private void checkedListBoxSport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Excel_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.ShowDialog();
            string filename=ofd.FileName;

            Microsoft.Office.Interop.Excel.Application excelObj=new Microsoft.Office.Interop.Excel.Application();
            excelObj.Visible = true;

            Workbook wb = excelObj.Workbooks.Open(filename,0,false,5,"","",false,XlPlatform.xlWindows,"",true,false,0,true,false,false);
            Worksheet wsh = wb.Sheets[1];
            for (int i = 0; i < users.Count; i++)
            {
                wsh.Cells[i+1, 1] = users[i].Name;
                wsh.Cells[i+1, 2] = users[i].City;
                wsh.Cells[i+1, 3] = users[i].Sport;
                wsh.Cells[i+1, 4] = users[i].Sex;
            }
            wb.Save();
            wb.Close();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    public class User
    {
        string name;
        string city;
        string sport;
        string sex;
        public User(string name, string city, string sport, string sex)
        {
            this.name = name;
            this.city = city;
            this.sport = sport;
            this.sex = sex;

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Sport
        {
            get { return sport; }
            set { sport = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

    }

}