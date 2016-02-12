using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace Prog
{
    public partial class Vedomost : Form
    {
        public Vedomost()
        {
            InitializeComponent();
            
            comboBox2.Enabled = true;

            _OC.ConnectionString = ora_conn;
            _OC.Open();
        }
        //
        //
        //Работа с базой данных
        //
        //
        string ora_conn = "DATA SOURCE=127.0.0.1:1521;PASSWORD=1234;PERSIST SECURITY INFO=True;USER ID=URR";
        OracleConnection _OC = new OracleConnection();
        OracleCommand command;

        DataTable DT;
        DataTable Works;
        DataTable VedomDT;
        DataTable Materilas;
        DataTable Ptr;

        

        string TableName = "Ved_pot_";
        
        private void ExecuteQuery(string txtQuery,OracleConnection ora_con)
        {
            if (ora_con.State.ToString() != "Open")
                ora_con.Open();

            command = ora_con.CreateCommand();
            command.CommandText = txtQuery;
            command.ExecuteNonQuery();
            ora_con.Close();
        }
        private DataTable LoadData(string CommandText, OracleConnection oracleConnection)
        {
            DataTable DT1 = new DataTable();
            OracleDataAdapter DA = new OracleDataAdapter(CommandText, oracleConnection);
            DataSet DS1 = new DataSet();
            DS1.Reset();
            DA.Fill(DS1);
            DT1 = DS1.Tables[0];
            oracleConnection.Close();
            return DT1;
        }

        //
        //
        //Обработчики событий
        //
        //
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button5.Enabled = false;
        }
        private void Vedomost_Load(object sender, EventArgs e)
        {
            try
            {
                

                DT = LoadData("SELECT * FROM SP_OBJ", _OC);
                  foreach (DataRow t in DT.Rows)
                    comboBox1.Items.Add(t[1].ToString());

            }
            catch (Exception Ex) { MessageBox.Show(Ex.ToString()); }
        }
        private void button1_Click(object sender, EventArgs e)
        {

           
                        
            TableName += "_"+comboBox2.SelectedItem.ToString();

            try
            {
                ExecuteQuery("SELECT * FROM "+TableName,_OC);
                MessageBox.Show("Таблица уже созданна");
                VedomDT = LoadData("SELECT * FROM " + TableName, _OC);
                dataGridView1.DataSource = VedomDT;
                button6.Enabled = true;
            }
            catch (Exception e1)
            {
                if (e1.Message.Split(':')[0] == "ORA-00942")
                {
                    
                    ExecuteQuery("CREATE table "+TableName+"(NAMEOBJ      VARCHAR2(50),NAMEMATERIAL VARCHAR2(50),GOST   VARCHAR2(20),EDIN  VARCHAR2(10),VSEGO NUMBER,JUL VARCHAR2(10),JULY VARCHAR2(10),AUGUST VARCHAR2(10),SEPTEMBER VARCHAR2(10),OKTOBER VARCHAR2(10),NOVEMBER VARCHAR2(10),DECEMBER VARCHAR2(10),JANUARY  VARCHAR2(10),FEBRAL VARCHAR2(10),MART VARCHAR2(10),APRIL VARCHAR2(10),MAY VARCHAR2(10))", _OC);
                    MessageBox.Show("Таблица успешно созданна");
                }
            }

            groupBox1.Enabled = true;

           // VedomDT = LoadData("SELECT * FROM"+TableName, _OC);
           // dataGridView1.DataSource = VedomDT;

        }
        private void button2_Click(object sender, EventArgs e)
        {

           // Works = LoadData("SELECT * FROM VEDOBRAB WHERE NAMEOBJ='"+comboBox1.SelectedItem.ToString()+"'",_OC);
            
            Materilas = LoadData("SElECT * FROM SP_MAT",_OC);

            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;


        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Works;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Materilas;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;

            string[] stroka = new string[6];
            string zapr = "INSERT INTO "+TableName+" VALUES ('"+comboBox1.SelectedItem.ToString()+"',";
            int k;
            

            Ptr = LoadData("SELECT * FROM VEDPVIEW WHERE NAMEOBJ='"+comboBox1.SelectedItem.ToString()+"'", _OC);

            foreach (DataRow Potr in Ptr.Rows)
            {
                stroka[0] = Potr[0].ToString();
                stroka[1] = Potr[3].ToString();
                stroka[4] = Potr[5].ToString();
                k = (int)Convert.ToInt32(Potr[5].ToString()) / 12 + 1;
                stroka[5] = k.ToString();
                
                    
                    foreach (DataRow Materiali in Materilas.Rows)
                    {
                        if (stroka[1] == Materiali[1].ToString())
                        {
                            stroka[2] = Materiali[2].ToString();
                            stroka[3] = Materiali[3].ToString();
                        // name obj,name mat,gost,edin,vsego
                            ExecuteQuery(zapr + "'" + stroka[1] + "','" + stroka[2] + "','" +
                                stroka[3] + "'," + stroka[4] + ",'" + stroka[5] + "','" + stroka[5] + "','" + stroka[5] +
                                "','" + stroka[5] + "','" + stroka[5] + "','" + stroka[5] + "','" + stroka[5] + "','" + stroka[5] +
                                "','" + stroka[5] + "','" + stroka[5] + "','" + stroka[5] + "','" + stroka[5] + "')", _OC);

                            stroka = new string[6];
                        }
                    }

               
            }

            VedomDT = LoadData("SELECT * FROM "+TableName,_OC);
            dataGridView1.DataSource = VedomDT;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application OXl;
                Excel._Workbook oWB;
                Excel._Worksheet Sheet;

                OXl = new Excel.Application();
                OXl.Visible = true;

                oWB = (Excel._Workbook)(OXl.Workbooks.Add(Missing.Value));
                Sheet = (Excel._Worksheet)oWB.ActiveSheet;

                Sheet.get_Range("A6", "E6").ColumnWidth = 23;

                Sheet.Cells[2,5]="Ведомость потребности материалов на "+comboBox2.SelectedItem.ToString();
                Sheet.Cells[4,2]="Документ составен программой";

                Sheet.Cells[6,1]= "Наименование объекта";
                Sheet.Cells[6,2]= "Наименование Материала";
                Sheet.Cells[6,3]= "Тип,Гост,Марка";
                Sheet.Cells[6,4]= "Ед. Измр.";
                Sheet.Cells[6,5]= "Всего";
                Sheet.Cells[6,6]= "Июнь";
                Sheet.Cells[6,7]= "Июль";
                Sheet.Cells[6,8]= "Август";
                Sheet.Cells[6,9]= "Сентябрь";
                Sheet.Cells[6,10]= "Октябрь";
                Sheet.Cells[6,11]= "Ноябрь";
                Sheet.Cells[6,12]= "Декабрь";
                Sheet.Cells[6,13]= "Январь";
                Sheet.Cells[6,14]= "Февраль";
                Sheet.Cells[6,15]= "Март";
                Sheet.Cells[6,16]= "Апрель";
                Sheet.Cells[6,17]= "Май";

                int Start = 7;

                foreach (DataRow _row in VedomDT.Rows)
                {
                    Sheet.Cells[Start, 1] = _row[0].ToString();
                    Sheet.Cells[Start, 2] = _row[1].ToString();
                    Sheet.Cells[Start, 3] = _row[2].ToString();
                    Sheet.Cells[Start, 4] = _row[3].ToString();
                    Sheet.Cells[Start, 5] = _row[4].ToString();
                    Sheet.Cells[Start, 6] = _row[5].ToString();
                    Sheet.Cells[Start, 7] = _row[6].ToString();
                    Sheet.Cells[Start, 8] = _row[7].ToString();
                    Sheet.Cells[Start, 9] = _row[8].ToString();
                    Sheet.Cells[Start, 10] = _row[9].ToString();
                    Sheet.Cells[Start, 11] = _row[10].ToString();
                    Sheet.Cells[Start, 12] = _row[11].ToString();
                    Sheet.Cells[Start, 13] = _row[12].ToString();
                    Sheet.Cells[Start, 14] = _row[13].ToString();
                    Sheet.Cells[Start, 15] = _row[14].ToString();
                    Sheet.Cells[Start, 16] = _row[15].ToString();
                    Sheet.Cells[Start, 17] = _row[16].ToString();


                    Start++;
                }

                OXl.UserControl = true;

                DrawBorders(Sheet, "A6", "Q"+Start.ToString());


            }
            catch (Exception ex)
            { 
            MessageBox.Show(ex.ToString());
            }

            _OC.Close();
            this.Close();
        }
        //
        //
        //Работа с Эксель
        //
        //
        private void DrawBorders(Excel._Worksheet oSheet, string FirstCell, string SecondCell)
        {
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
        }
    }
}
