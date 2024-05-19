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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.ApplicationServices;


namespace rabota2
{
    public partial class ReportForm : Form
    {
        public NpgsqlConnection con;
        System.Data.DataTable dt = new System.Data.DataTable();
        DataSet ds = new DataSet();
        public ReportForm(NpgsqlConnection con)
        {

            InitializeComponent();
            this.con = con;

        }

        private void accept_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridView1);
        }
        private void ExportToExcel(DataGridView dataGridView)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;
            excelApp.Visible = true;

            // Заголовки столбцов
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
            }

            // Данные строк
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                }

            }


            // Опционально: автоматическое форматирование столбцов
            worksheet.Columns.AutoFit();

            // Сохранение файла (опционально)
            // string filePath = @"C:\path\to\your\file.xlsx";
            // worksheet.SaveAs(filePath);

            // Освобождение ресурсов
            releaseObject(worksheet);
            releaseObject(excelApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


        private void ReportForm_Load(object sender, EventArgs e)
        {
           /* int day1 = dateTimePicker1.Value.Day;
            int month1 = dateTimePicker1.Value.Month;
            int year1 = dateTimePicker1.Value.Year;
            int day2 = dateTimePicker2.Value.Day;
            int month2 = dateTimePicker2.Value.Month;
            int year2 = dateTimePicker2.Value.Year;
            String sql = String.Format("select * from futura where data>= '{1}-{2}-{3}' and data<= '{4}-{5}-{6}'", day1, month1, year1, day2, month2, year2);
            richTextBox1.AppendText(sql);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Номер поставщика";
            dataGridView1.Columns[2].HeaderText = "Дата";
            dataGridView1.Columns[3].HeaderText = "Сумма";
            StartPosition = FormStartPosition.CenterScreen;*/
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int day1 = dateTimePicker1.Value.Day;
            int month1 = dateTimePicker1.Value.Month;
            int year1 = dateTimePicker1.Value.Year;
            int day2 = dateTimePicker2.Value.Day;
            int month2 = dateTimePicker2.Value.Month;
            int year2 = dateTimePicker2.Value.Year;
            String sql = String.Format("select data,totalsum,sup_name from futura as fut join futura_info as fut_i on(fut.id_futura=fut_i.id_futura) join supplier as sup on (fut.id_supplier=sup.id_supplier) where data>= '{0}-{1}-{2}' and data<= '{3}-{4}-{5}'and payment=false and data< current_date", year1, month1, day1, year2, month2, day2);
            richTextBox1.AppendText(sql);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Дата";
            dataGridView1.Columns[1].HeaderText = "Сумма длога";
            dataGridView1.Columns[2].HeaderText = "Имя поставщика";
            //dataGridView1.Columns[2].HeaderText = "Дата";
            //dataGridView1.Columns[3].HeaderText = "Сумма";
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}







/*public void Update()
        {
            
            String sql = "Select * from futura";
            richTextBox1.AppendText(sql);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Номер поставщика";
            dataGridView1.Columns[2].HeaderText = "Дата";
            dataGridView1.Columns[3].HeaderText = "Сумма";
            StartPosition = FormStartPosition.CenterScreen;

        }*/

