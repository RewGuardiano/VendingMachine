using Oracle.ManagedDataAccess.Client;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineSYS
{
    internal class Order
    {
        private int orderId;
        private int orderNumber;
        private int menuId;

        // Specify -1 for orderId to create a unique ID for the database.

        public Order(int orderId, int orderNumber, int menuId)
        {
            if (orderId == -1)
            {
                DeduceID();
            } 
            else 
            {
                this.orderId = orderId;
            }
            this.orderNumber = orderNumber;
            this.menuId = menuId;
        }

        public int GetOrderId()
        {
            return orderId;
        }
        public int GetOrderNumber()
        {
            return orderNumber;
        }
        public int GetMenuId() { 
            return menuId;
        }
        public void SetOrderNumber(int orderNumber) 
        { 
            this.orderNumber=orderNumber;
        }
        public void SetMenuID(int menuId)
        {
            this.menuId=menuId;
        }

        // Use this function to set an appropriate ID number based on the next ID which can be used in the database without conflict with the primary key constraint. 

        public void DeduceID()
        {
           /* DBConnect.oradb is the connection string accessed from the Program.cs file as a static member of a project-internally visible Program class.
            * 
            * May be declared in Program.cs as:
            * 
            * orderNumberspace VendingMachineSYS
            * {
            *      static class Program
            *      {
            *          public static string connectionStr ** Set the Value to the Connection String **;
            *          
            *                      .
            *                      .    ** Class Body (other attributes, methods, etc.) **
            *                      .
            *                      
            *      }
            * }
            * 
            */

            OracleConnection connection = new OracleConnection(DBConnect.oradb);
            try
            {
                connection.Open();
            } catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to the database.\n\n" + ex.Message + "\n\n" + ex.StackTrace);
            }

            // Check in case no Menu objects have been added yet. If none are found, set the ID to 0

            int numItems = 0;
            DataSet dataSet = new DataSet("Unnamed");
            OracleDataAdapter da = new OracleDataAdapter("SELECT * FROM ORDERS", connection);
            try
            {
                da.Fill(dataSet);
                numItems = dataSet.Tables[0].Rows.Count;  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to deduce ID for an instance of \"Order\".\n\n" + ex.Message + "\n\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // If there are other Menu objects in the database, deduce the appropriate ID. Set the ID to the greatest existing ID + 1

            if (numItems > 0)
            {
                try
                {
                    OracleDataReader r = new OracleCommand("SELECT MAX(OID) FROM ORDERS", connection).ExecuteReader();
                    r.Read();
                    orderId = r.GetInt32(0)+1;
                    r.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to deduce ID for an instance of \"Order\".\n\n" + ex.Message + "\n\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    orderId = -1;
                }
            }
            else
            {
                orderId = 0;
            }
            connection.Close();
        }
        public bool AddOrder()
        {
            if (OrderExists(orderId)) return true;
            string commandStr = "INSERT INTO ORDERS VALUES(" + orderId + ", '" + orderNumber + "', " + menuId + ")";
            try
            {
                OracleConnection connection = new OracleConnection(DBConnect.oradb);
                connection.Open();
                OracleCommand command = new OracleCommand(commandStr, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            } catch (Exception ex)
            {
                MessageBox.Show(commandStr + ": Failed to perform database operation.\n\n" + ex.Message + "\n\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        private bool OrderExists(int oID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            string sqlQuery = "SELECT COUNT(*) FROM ORDERS WHERE OID = :OID";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(new OracleParameter(":OID", oID));
            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return count > 0; // Return true if the category exists, false otherwise
        }
        public bool UpdateOrder()
        {
            string commandStr = "UPDATE ORDERS SET OID=" + orderId + ", ORDERNUMBER ='" + orderNumber + "', MENUID=" + menuId + " WHERE OID=" + orderId;
            try
            {
                OracleConnection connection = new OracleConnection(DBConnect.oradb);
                connection.Open();
                OracleCommand command = new OracleCommand(commandStr, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(commandStr + ": Failed to perform database operation.\n\n" + ex.Message + "\n\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool DeleteOrder()
        {
            string commandStr = "DELETE FROM ORDERS WHERE OID=" + orderId;
            try
            {
                OracleConnection connection = new OracleConnection(DBConnect.oradb);
                connection.Open();
                OracleCommand command = new OracleCommand(commandStr, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(commandStr + ": Failed to perform database operation.\n\n" + ex.Message + "\n\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
