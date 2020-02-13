using System;
using System.Data.SqlClient;

namespace OrderTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }


    public class OrderItem
    {
        public int ItemQty { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public double PerItemPrice { get; set; }
        public double TotalPrice { get; set; }
    }







    public class EnterDB
    {
        public static void EnterIntoDb(Int32 orderQty, string itemID, string itemName, double PerItemPrice, double TotalPrice)
        {

            SqlConnection mainConn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=OrderDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            SqlCommand commands = new SqlCommand(@"INSERT INTO (OrderQty, ItemID, ItemName,PerItemPrice,TotalPrice) VALUES (" +
                                                    orderQty + "," + itemID + "," + itemName + "," + PerItemPrice + "," + TotalPrice + ");");

            using (mainConn)
            {
                try
                {
                    mainConn.Open();
                    commands.Connection = mainConn;
                    commands.ExecuteNonQuery();
                    SqlTransaction sqlTransaction = commands.Transaction;
                    sqlTransaction.Commit();

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {

                    mainConn.Close();
                    mainConn.Close();
                }
            }
        }

    }



}



















