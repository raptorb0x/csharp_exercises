using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows;

namespace PracticProject.WorkClasses
{
    class WorkСlass
    {
       static public string ConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
            }
        }
       static public DataTable ReadRequest(string query)
        {
            try
            {
                // создаем подключение
                using (System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(ConnectionString))
                {
                    // открываем подключение
                    connection.Open();
                    // создаем Адаптер данных
                    OleDbDataAdapter oleDataAdapter = new OleDbDataAdapter();
                    // создаем SQL команду
                    oleDataAdapter.SelectCommand = new OleDbCommand(query, connection);
                    // созздаем временную таблицу
                    DataTable tempDataTable = new DataTable();
                    // записываем результат выполнения SQL запроса во временную таблицу
                    oleDataAdapter.Fill(tempDataTable);
                    // закрываем соединение
                    connection.Close();
                    // возвращаем результат
                    return tempDataTable;
                }
            }
            // Обработка исключения
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
       public enum FormMode
       {
           AddMode, ChangeMode,
       }
       public class ComboboxContent
       {
           public string Id
           {
               get;
               set;
           }
           public string Value
           {
               get;
               set;
           }
       }
       public static DataTable ExecuteRequest(string query)
       {
           try
           {
               // создаем адаптер данных используя наш запрос и строку контента с базой
               OleDbDataAdapter BaseAdapter = new OleDbDataAdapter(query, ConnectionString);
               // создаем datatable в которую будет записываться результат
               DataTable outDataTable = new DataTable();
               // выполняем запрос - заполняем DataTable результатом
               BaseAdapter.Fill(outDataTable);
               // (в нашем случае она будет пустой (не путать с null))
               return outDataTable;
           }
           catch (Exception ex)
           {
               new Forms.Window1(MessageBoxButton.OK, ex.Message);
               return null;
           }
       }

    }
}
