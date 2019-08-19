using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Lab04
{
    public partial class Lab04b : System.Web.UI.Page
    {
        public String connStr = "Data Source=ecnmssqldev.ecn.purdue.edu;Initial Catalog=zCGT456_ramakri7;Integrated Security=True";
        public String SQL;
        public SqlConnection oConn;
        public SqlCommand oCmd;
        public SqlDataReader sdr;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Nothing here
        }

        private void ExecNonQuery(String splPassedIn)
        {
            oConn = new SqlConnection(connStr);             // Create connection
            oCmd = new SqlCommand(splPassedIn, oConn);      // Send the SQL statement to DB
            oCmd.Connection.Open();                         // Open active connection
            oCmd.ExecuteNonQuery();                         // Execute statement that is !SELECT
            oCmd.Connection.Close();                        // Close DB Connection
        } // end ExecNonQuery

        protected void select_Click(object sender, EventArgs e)
        {
            SQL = "SELECT * FROM Products_Lab4";            // Store SQL statement
            oConn = new SqlConnection(connStr);             // Create a connection
            oConn.Open();                                   // Open active connection
            oCmd = new SqlCommand(SQL, oConn);              // Send the SQL Statement
            sdr = oCmd.ExecuteReader();                     // Read results
            myDataGrid.DataSource = sdr;                    // Set myDataGrid
            myDataGrid.DataBind();                          // Show reults
            oConn.Close();                                  // Close connection
        } // end select_Click

        protected void insert_Click(object sender, EventArgs e)
        {
            String title = "Intro to C#";
            String authors = "Whoever, Somebody A.";

            SQL = "Insert INTO Products_Lab4(title, authors, copyrightDate, edition, isbn, convert, descripion, price) ";
            SQL += "Values('" + title + "', '" + authors + "', '060220', '4th', '123456789', 'computer image', 'intro to asp.net', '200.00')";
            ExecNonQuery(SQL);
            select_Click(sender, e);
        } // end insert_Click

        protected void update_Click(object sender, EventArgs e)
        {
            SQL = "UPDATE Products_Lab4 SET Title='C# is FUN' WHERE ProductID=(SELECT MAX(ProductID) AS maxID FROM Products_LAb4)";
            ExecNonQuery(SQL);
            select_Click(sender, e);
        } // end update_Click

        protected void delete_Click(object sender, EventArgs e)
        {
            SQL = "DELETE FROM Products_Lab4 WHERE ProductID=(Select MAX(ProductID) AS maxID FROM Products_Lab4)";
            ExecNonQuery(SQL);
            select_Click(sender, e);
        } // end delete_Click
    }
}