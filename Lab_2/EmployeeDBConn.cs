using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;

namespace Lab_2
{

    internal class EmployeeDBConn
    {
        private string connectionString = @"Data Source =(localdb)\MSSQLLocalDB;Initial Catalog = EmployeeDB; Integrated Security =True;";
        private int rowsAffected;

        public bool Insert(String Id, String Name, String Cell, String Address)
        {
            String Query = "INSERT INTO Employee (id, Name, Cell, Address) Values (@Id, @Name, @Cell, @Address)";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(Query, con);


                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Cell", Cell);
                    cmd.Parameters.AddWithValue("@Address", Address);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Database Error: " + ex.Message);
                return false;
            }


        }
        public bool Update(string Id, string name, string cell, string address)
        {
            string query = "Update Employee set Name = @Name, cell = @cell, Address = @Address Where Id = @Id";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@cell", cell);
                    cmd.Parameters.AddWithValue("@Address", address);

                    con.Open();
                    int rowAffected = cmd.ExecuteNonQuery();
                    return rowAffected > 0;

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error:", ex.Message);
                return false;
            }
        }
        public bool Delete(String Id)
        {
            String query = "Delete from Employee where Id = @Id";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error:" + ex.Message);
                return false;
            }
        }
        public System.Data.DataTable FetchAll(string id)
        {
            string query = "SELECT Id, Name, Cell, Address FROM Employee";
            System.Data.DataTable dataTable = new System.Data.DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            return dataTable;
        }
    }
}
