using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using System.Data.SqlClient;
using System.Data.Common;
using System.Globalization;
using System.IO;

namespace BankRetail
{
    class DAL
    {
        /// <summary>
        /// Строка соединения
        /// Intergrated Security=True;
        /// </summary>
        //string connectinString = @"Persist Security Info=False;Integrated Security=true;Initial Catalog=Bank;Data Source=SHYKOR";
        string connectinString = @"Data Source=localhost;Initial Catalog=Bank;Integrated Security=true;";

        public ArrayList GetAllDebitors()
        {
            ArrayList allDebitors = new ArrayList();

            using (SqlConnection con = new SqlConnection(connectinString))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Debitors ORDER BY Name DESC", con);

                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    //SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                            allDebitors.Add(result);
                    }

                    //con.Dispose();

                }
                catch { }

            }
            return allDebitors;
        }

        public ArrayList GetAllCreditsForDebitor(string debitorID)
        {
            ArrayList allCredits = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectinString))
            {
                //string query = String.Format("SELECT * FROM Credits WHERE DebitorID = '{0}' ORDER BY OpenDate", debitorID);
                
                
                //SqlCommand com = new SqlCommand(query, con);

                SqlCommand com = new SqlCommand("GetAllCreditsForDebitor", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@debitorID";
                param.Value = new Guid(debitorID);
                param.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                param.Direction = System.Data.ParameterDirection.Input;
                com.Parameters.Add(param);

                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    //SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                            allCredits.Add(result);
                    }

                    //con.Dispose();

                }
                catch { }

            }
            return allCredits;
        }


        public ArrayList GetAllPaymentsForCredit(string creditID)
        {
            ArrayList allCredits = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectinString))
            {
                string query = String.Format("SELECT * FROM Payments WHERE CreditsID = '{0}'", creditID);
                SqlCommand com = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    //SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                            allCredits.Add(result);
                    }

                    //con.Dispose();

                }
                catch { }

            }
            return allCredits;
        }

        public bool SaveNewDebitor(string ID, string Name, string PostNumber, string PhoneNumber)
        {
            bool flag = false;

            string query = string.Format("INSERT INTO Debitors ([ID], [Name], [PostNumber], [PhoneNumber]) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}')", ID, Name, PostNumber, (PhoneNumber != string.Empty) ? PhoneNumber : null);

            using (SqlConnection con = new SqlConnection(connectinString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {
                    con.Open();

                    if(com.ExecuteNonQuery() == 1)
                        flag = true;
                }
                catch { }

            }

            return flag;
        }

        public bool SaveNewCredit(Guid ID, Guid DebitorID, int Amount, int Balance, DateTime OpenDate)
        {

            bool flag = false;

            //string query = String.Format("INSERT INTO Credits ([ID], [DebitorID], [Amount], [Balance], [OpenDate]) " +
            //    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", ID, DebitorID, Amount, Balance, OpenDate);

            string query = String.Format("INSERT INTO Credits ([ID], [DebitorID], [Amount], [Balance], [OpenDate]) VALUES (@ID, @DebitorID, @Amount, @Balance, @OpenDate)");

            using (SqlConnection con = new SqlConnection(connectinString))
            {
                SqlCommand com = new SqlCommand(query, con);

                SqlParameter param = new SqlParameter("@ID", ID);
                param.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DebitorID";
                param.Value = DebitorID;
                param.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Amount";
                param.Value = Amount;
                param.SqlDbType = System.Data.SqlDbType.Money;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Balance";
                param.Value = Balance;
                param.SqlDbType = System.Data.SqlDbType.Money;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@OpenDate";
                param.Value = OpenDate;
                param.SqlDbType = System.Data.SqlDbType.DateTime;
                com.Parameters.Add(param);

                try
                {
                    con.Open();

                    if (com.ExecuteNonQuery() == 1)
                        flag = true;
                }
                catch { }

            }

            return flag;
        }

        public bool SaveNewPayment(Guid ID, Guid CreditID, decimal paymentAmount, DateTime DateTime)
        {
            bool flag = true;

            using (SqlConnection con = new SqlConnection(connectinString))
            {
                con.Open();
                SqlTransaction sqlTransaction = con.BeginTransaction();
                SqlCommand com = con.CreateCommand();
                com.Transaction = sqlTransaction;

                try
                {
                    string PA = paymentAmount.ToString(CultureInfo.InvariantCulture.NumberFormat);
                    string query = String.Format("INSERT INTO Payments ([ID], [CreditsID], [Amount], [PaymentDate]) " +
                        "VALUES ('{0}', '{1}', '{2}', CURRENT_TIMESTAMP)", ID, CreditID, PA, DateTime);
                    
                    // CURRENT_TIMESTAMP

                    com.CommandText = query;
                    com.ExecuteNonQuery();

                    query = String.Format("UPDATE Credits SET Balance = (Balance - {0}) WHERE ID = '{1}'", PA, CreditID);
                    com.CommandText = query;
                    com.ExecuteNonQuery();

                    sqlTransaction.Commit();

                }
                catch(Exception)
                {
                    sqlTransaction.Rollback();
                    flag = false;
                }
                finally
                {
                    if(con.State == System.Data.ConnectionState.Open)
                    {
                        con.Dispose();
                    }
                }
            }

            return flag;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool SaveDBToLocalFile()
        {
            StreamWriter file;

            string query;
            using (SqlConnection con = new SqlConnection(connectinString))
            {
                try
                {

                    file = new StreamWriter(new FileStream("Debitors.cvs", FileMode.Create), Encoding.GetEncoding(1251));

                    query = "SELECT * FROM Debitors";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();

                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID"";""Name"";""PostNumber"";""PhoneNumber""");

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" +
                                reader.GetString(1) + @""";""" + reader[2].ToString() + @""";""" +
                                reader[3].ToString() + @"""", Encoding.ASCII);
                        }
                    }
                    else
                    {
                        file.WriteLine("No one row to save");
                    }

                    file.WriteLine("End of file");
                    file.Dispose();

                }
                catch
                {
                    return false;
                }
            }

            using (SqlConnection con = new SqlConnection(connectinString))
            {
                try
                {
                    file = new StreamWriter(new FileStream("Debitors.cvs", FileMode.Create), Encoding.GetEncoding(1251));

                    query = "SELECT * FROM Credits";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();

                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID"";""DebitorID"";""Amount"";""Balance"";""OpenDate""");

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + 
                                reader[0].ToString() + @""";""" +
                                reader[1].ToString() + @""";""" +
                                reader[2].ToString() + @""";""" +
                                reader[3].ToString() + @""";""" +
                                reader[4].ToString() + @""";""", Encoding.ASCII);
                        }
                    }
                    else
                    {
                        file.WriteLine("No one row to save");
                    }

                    file.WriteLine("End of file");
                    file.Dispose();

                }
                catch
                {
                    return false;
                }
            }

            using (SqlConnection con = new SqlConnection(connectinString))
            {
                try
                {
                    file = new StreamWriter(new FileStream("Payments.cvs", FileMode.Create), Encoding.GetEncoding(1251));

                    query = "SELECT * FROM Payments";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();

                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID"";""CreditsID"";""Amount"";""PaymentDate""");

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" +
                                reader[0].ToString() + @""";""" +
                                reader[1].ToString() + @""";""" +
                                reader[2].ToString() + @""";""" +
                                reader[3].ToString() + @""";""", Encoding.ASCII);
                        }
                    }
                    else
                    {
                        file.WriteLine("No one row to save");
                    }

                    file.WriteLine("End of file");
                    file.Dispose();

                }
                catch
                {
                    return false;
                }
            }

            return true;
        }
    }


}
