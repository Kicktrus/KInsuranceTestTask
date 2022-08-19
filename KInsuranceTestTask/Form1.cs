using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace KInsuranceTestTask
{
    public partial class Form1 : Form
    {

        private SqlConnection connection;
        private DataSet dataSet;
        public string filterString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;//получение строки подключения из файла конфига (App.Config)
            connection = new SqlConnection(connectionString);
            FillDataSet();
        }

        //Наполнение набора данных (переменная dataSet) из сервера
        private void FillDataSet(int taskNum = 1)
        {
            string qry = "";//срока запроса
            switch (taskNum)//Какую процедуру вызвать для получения данных
            {
                case 1:
                    qry = "EXEC KInsuranceTestTaskFirst";//Задача 1
                    break;
                case 2:
                    qry = "EXEC KInsuranceTestTaskSecond";//Задача 2
                    break;
                case 3:
                    qry = "EXEC KInsuranceTestTaskThird";//Задача 3
                    break;
            }
            SqlDataAdapter adapter = new SqlDataAdapter(qry, connection);
            dataSet = new DataSet();

            connection.Open();
            adapter.Fill(dataSet, "DefaultTable");
            connection.Close();

            filterString = null;
            filterLabel.Text = "Нет фильтра";

            FillDataGrid();
        }

        //Заполнение DataGridView данными от dataSet
        private void FillDataGrid()
        {
            dataOutput.DataSource = dataSet;
            dataOutput.DataMember = "DefaultTable";
        }

        //Кнопка "Задача 1" на верху
        private void task1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillDataSet(1);
        }

        //Кнопка "Задача 2" на верху
        private void task2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillDataSet(2);
        }

        //Кнопка "Задача 3" на верху
        private void task3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillDataSet(3);
        }

        ////Кнопка "Снять фильтр" на верху
        private void removeFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterString = null;
            filterLabel.Text = "Нет фильтра";
            FillDataGrid();
        }

        //При нажатии правой кнопки мыши по колонке. Вызывает форму для установки фильтрации.
        private void dataOutput_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                FilterForm filterForm = new FilterForm();
                string columnName = dataSet.Tables[0].Columns[e.ColumnIndex].ColumnName;//Получение названия выбранной колонки

                //Собирает все строки под колонкой, и подставляет их как выбор для фильтрации в форме(FilterForm) 
                filterForm.filterDropBox.Items.AddRange((from DataGridViewRow row in dataOutput.Rows select row.Cells[columnName].Value.ToString()).Distinct().ToArray());

                filterForm.ShowDialog();

                //Строка для фильтрации 
                string newFilterVal = filterForm.filterValue;

                //Если в форме для выбора фильтра было что-то выбрано.
                if (!String.IsNullOrEmpty(newFilterVal))
                {
                    //Если ранее уже стоял фильтр, то к нему добавляется ещё один, в противном случе - создаётся новый
                    if (String.IsNullOrEmpty(filterString))
                    {
                        filterString = String.Format("[{0}] = '{1}'", columnName, newFilterVal);
                    }
                    else
                    {
                        filterString += String.Format(" AND [{0}] = '{1}'", columnName, newFilterVal);
                    }
                    filterLabel.Text = filterString;//Показывает фильтр в нижней части экрана
                }

                /*  
                 *  Создание нового набора данных на основе ранее созданного dataSet, который будет отфильтрован локально.
                 *  В случае удаления фильтра, программа возвращается в изначальный dataSet.
                 */
                System.Data.DataTable dataTable = dataSet.Tables[0];
                dataTable.DefaultView.RowFilter = filterString;
                dataOutput.DataSource = dataTable.DefaultView;
            }
        }

        //Эксопрт в CSV
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Данные.csv";
            bool fileError = false;
            
            //Открытие диалога для сохранения
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //Если файл уже существует, заменить.
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("Не удалось сохранить файл: " + ex.Message);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        int columnCount = dataOutput.Columns.Count;//Кол-во колон
                        string columnNames = "";
                        string[] outputCsv = new string[dataOutput.Rows.Count + 1];

                        //Вывод названий колон, с разделителем - запятой.
                        for (int i = 1; i < columnCount; i++)
                        {
                            columnNames += dataOutput.Columns[i].HeaderText.ToString() + ",";
                        }
                        outputCsv[0] += columnNames;

                        //Вывод остальных строк, с разделителем - запятой.
                        for (int i = 1; i < dataOutput.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                outputCsv[i] += dataOutput.Rows[i - 1].Cells[j].Value.ToString() + ",";
                            }
                        }

                        File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                        MessageBox.Show("Экспорт прошел успешно.", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка :" + ex.Message);
                    }
                }
            }
        }
    }
}
