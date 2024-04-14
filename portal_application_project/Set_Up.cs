using System;
using System.IO;
using Oracle.ManagedDataAccess.Client;

namespace ExecuteSQLFromFile
{
    public class SQLFileExecutor
    {
        private string connectionString;

        public SQLFileExecutor(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void ExecuteSQLFromFile(string filePath)
        {
            // Thay thế chuỗi kết nối này bằng chuỗi kết nối thực tế của bạn đến cơ sở dữ liệu Oracle

            try
            {
                string[] sqlCommands = File.ReadAllText(filePath).Split(";\r\n/");
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    foreach (string sqlCommand in sqlCommands)
                    {
                        MessageBox.Show(sqlCommand);
                        using (OracleCommand command = new OracleCommand(sqlCommand, connection))
                        {
                            command.ExecuteNonQuery();
                        }


                    }

                    Console.WriteLine("SQL commands executed successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}