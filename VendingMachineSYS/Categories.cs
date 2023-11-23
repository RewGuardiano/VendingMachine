using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace VendingMachineSYS
{

  
   public class Categories
    {
        public int CatID;
        public String Name;
        public String Description;

        public Categories()
        {
            this.CatID = 0;
            this.Name = "";
            this.Description = "";
        }

        public Categories(int catID, string name, string description)
        {
            CatID = catID;
            Name = name;
            Description = description;
        }
        public int getCatID()
        {
            return this.CatID;
        }
        public void setCatID(int catID)
        {
            this.CatID = catID;

        }
        public String getName()
        {
            return this.Name;
        }
        public void setName(String Name)
        {
            this.Name = Name;
        }
        public String getDescription()
        {
            return this.Description;
        }

        public void setDescription(String description)
        {

            this.Description = description;
        }

        
        public void getCategory(int CatID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM CATEGORIES WHERE CatID =  " + CatID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.Read()) // Check if there are rows to read
            {
                // Use the data from the OracleDataReader to populate the object's properties
                setCatID(dr.GetInt32(dr.GetOrdinal("CatID")));
                setName(dr.GetString(dr.GetOrdinal("Name")));
                setDescription(dr.GetString(dr.GetOrdinal("Description")));
            }
            else
            {
                // Handle the case where no data was found for the given CatID
                setCatID(0); 
                setName("");
                setDescription("");
            }


            conn.Close();


        }
        public void SetCategory(int catID, string name, string description)
        {
            // Check if the category already exists in the database
            if (!CategoryExists(catID))
            {
                // If the category does not exist, add it to the database
                OracleConnection conn = new OracleConnection(DBConnect.oradb);
                string sqlQuery = "INSERT INTO CATEGORIES (CatID, Name, Description) " +
                                  "VALUES (:catID, :Name, :Description)";
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                cmd.Parameters.Add(new OracleParameter(":catID", catID));
                cmd.Parameters.Add(new OracleParameter(":Name", name));
                cmd.Parameters.Add(new OracleParameter(":Description", description));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                throw new Exception("Category already exists");
            }
        }

        public bool CategoryExists(int catID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            string sqlQuery = "SELECT COUNT(*) FROM CATEGORIES WHERE CatID = :catID";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(new OracleParameter(":catID", catID));
            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return count > 0; // Return true if the category exists, false otherwise
        }

        public static Categories FindCategoryByName(string categoryName)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand query = new OracleCommand("SELECT * FROM CATEGORIES WHERE NAME LIKE '" + categoryName + "'", conn);
            OracleDataReader reader = query.ExecuteReader();
            reader.Read();
            Categories category = new Categories(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            conn.Close();
            return category;
        }
    }
}

