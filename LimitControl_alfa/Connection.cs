using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimitControl_alfa
{
    public static class Connection
    {
        private static string strConn =
            string.Format(
                @"Data Source = ESAVITSKY; Initial Catalog = LimitsDB; Integrated Security = True; Pooling = true");

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(strConn);
            return connection;
        }

        public static void LoadDataInTable(string cmdText, DataTable table)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                MessageBox.Show(connection.State.ToString());SqlCommand cmd = new SqlCommand(cmdText, connection);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    try
                    {
                        adapter.Fill(table);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("{0}: {1}", DateTime.Now, ex.Message), ex.GetType().ToString(), MessageBoxButtons.RetryCancel);
                    }
                }
            }
        }


        public static void RunTransaction(string cmbText)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("T1");
                cmd.Connection = connection;
                cmd.Transaction = transaction;
                try
                {
                    cmd.CommandText = cmbText;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Both records are written to database", "Sucsess", MessageBoxButtons.OK);
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(string.Format("Commit Exeption Type: {0}.\n Message: {1}",
                        ex1.GetType(), ex1.Message), "Error", MessageBoxButtons.OK);
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show(string.Format("Rollback Exeption Type: {0}.\n Message: {1}",
                            ex2.GetType(), ex2.Message), "Error", MessageBoxButtons.OK);
                    }

                }

            }
        }

    }
}
