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
    public partial class Lab04a : System.Web.UI.Page
    {
        public String connStr = "Data Source=ecnmssqldev.ecn.purdue.edu;Initial Catalog=zCGT456_ramakri7;Integrated Security=True";
        public String SQL;
        public SqlConnection oConn;
        public SqlCommand oCmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            SQL = "SELECT DISTINCT title FROM EmployeesLab4";   // Store SQL statement
            oConn = new SqlConnection(connStr);                 // Create connection
            oConn.Open();                                       // Open active connection
            oCmd = new SqlCommand(SQL, oConn);                  // Send SQL statement to DB
            myList.DataSource = oCmd.ExecuteReader();           // Read results and set myList to those results
            myList.DataBind();                                  // Actually show the results
            oConn.Close();                                      // Close the DB Active connection

            // Get the first and last names and concatanate them
            oConn.Open();                                       // Open active connection
            SQL = "SELECT CONCAT(FirstName, ' ', LastName) AS FLnames FROM EmployeesLAb4";
            oCmd = new SqlCommand(SQL, oConn);                  // Send SQL statement to DB
            names.DataSource = oCmd.ExecuteReader();
            names.DataBind();
            oConn.Close();

            // Get the home phone number
            oConn.Open();                                       // Open active connection
            SQL = "SELECT HomePhone FROM EmployeesLAb4";
            oCmd = new SqlCommand(SQL, oConn);                  // Send SQL statement to DB
            phones.DataSource = oCmd.ExecuteReader();
            phones.DataBind();
            oConn.Close();

            // Get the city
            oConn.Open();                                       // Open active connection
            SQL = "SELECT City FROM EmployeesLAb4";
            oCmd = new SqlCommand(SQL, oConn);                  // Send SQL statement to DB
            cities.DataSource = oCmd.ExecuteReader();
            cities.DataBind();
            oConn.Close();
        }
    }
}