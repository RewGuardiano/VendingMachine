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
    internal class MenuItem
    {
        private int menuItemId;
        private string name;
        private float price;
        private string description;
        private int catId;
        private float calories;

        // Specify -1 for menuItemId to create a unique ID for the database.

        public MenuItem(int menuItemId, string name, float price, string description, int catId, float calories)
        {
            if (menuItemId == -1)
            {
                DeduceID();
            } 
            else 
            {
                this.menuItemId = menuItemId;
            }
            this.name = name;
            this.price = price;
            this.description = description;
            this.catId = catId;
            this.calories = calories;
        }

        public int GetMenuItemId()
        {
            return menuItemId;
        }

        public string GetName()
        {
            return name;
        }
        public float GetPrice() 
        { 
            return price;
        }
        public string GetDescription()
        {
            return description;
        }
        public int GetCatId()
        {
            return catId;
        }
        public float GetCalories() { 
            return calories;
        }

        // Use this function to set an appropriate ID number based on the next ID which can be used in the database without conflict with the primary key constraint. 

        public void DeduceID()
        {
           /* DBConnect.oradb is the connection string accessed from the Program.cs file as a static member of a project-internally visible Program class.
            * 
            * May be declared in Program.cs as:
            * 
            * namespace VendingMachineSYS
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
            OracleDataAdapter da = new OracleDataAdapter("SELECT * FROM MENU", connection);
            try
            {
                da.Fill(dataSet);
                numItems = dataSet.Tables[0].Rows.Count;  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to deduce ID for an instance of \"Menu\".\n\n" + ex.Message + "\n\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // If there are other Menu objects in the database, deduce the appropriate ID. Set the ID to the greatest existing ID + 1

            if (numItems > 0)
            {
                try
                {
                    OracleDataReader r = new OracleCommand("SELECT MAX(MENUID) FROM MENU", connection).ExecuteReader();
                    r.Read();
                    menuItemId = r.GetInt32(0)+1;
                    r.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to deduce ID for an instance of \"Menu\".\n\n" + ex.Message + "\n\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    menuItemId = -1;
                }
            }
            else
            {
                menuItemId = 0;
            }
            connection.Close();
        }
        public bool AddMenuItem()
        {

            if (MenuItemExists(menuItemId)) return true;
            string commandStr = "INSERT INTO MENU VALUES(" + menuItemId + ", '" + name + "', " + price + ", '" + description + "', " + catId + ", " + calories + ")";
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

        private bool MenuItemExists(int miID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            string sqlQuery = "SELECT COUNT(*) FROM MENU WHERE MENUID = :menuID";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(new OracleParameter(":menuID", miID));
            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return count > 0; // Return true if the category exists, false otherwise
        }
        public bool UpdateMenuItem()
        {
            string commandStr = "UPDATE MENU SET MENUID=" + menuItemId + ", NAME='" + name + "', PRICE=" + price + ", DESCRIPTION='" + description + "', CATID=" + catId + ", CALORIES=" + calories + " WHERE MENUID=" + menuItemId;
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
        public bool DeleteMenuItem()
        {
            string commandStr = "DELETE FROM MENU WHERE MENUID=" + menuItemId;
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

        public static MenuItem FindMenuItemByName(string menuItemName)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand query = new OracleCommand("SELECT * FROM MENU WHERE NAME LIKE '" + menuItemName + "'", conn);
            OracleDataReader reader = query.ExecuteReader();
            reader.Read();
            MenuItem menuItem = new MenuItem(reader.GetInt32(0), reader.GetString(1), reader.GetFloat(2), reader.GetString(3), reader.GetInt32(4), reader.GetFloat(5));
            conn.Close();
            return menuItem;
        }
    }
}
