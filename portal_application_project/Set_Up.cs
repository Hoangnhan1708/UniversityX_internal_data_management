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
            try
            {
                // Mở tệp SQL để đọc
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string sqlStatement = "";
                    string line;
                    // Đọc từng dòng trong tệp
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Kiểm tra dòng có phải là một câu lệnh SQL không
                        if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith("--"))
                        {
                            sqlStatement += line.Trim() + " ";

                            // Kiểm tra xem câu lệnh SQL đã hoàn chỉnh chưa (kết thúc bằng dấu chấm phẩy)
                            if (line.Trim().EndsWith(";"))
                            {
                                
                                // Thực thi câu lệnh SQL
                                ExecuteSQL(sqlStatement);
                                // Reset sqlStatement để đọc câu lệnh SQL tiếp theo
                                sqlStatement = "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void ExecuteSQL(string sqlStatement)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(sqlStatement, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing SQL: " + ex.Message);
            }
        }
    }

    
}