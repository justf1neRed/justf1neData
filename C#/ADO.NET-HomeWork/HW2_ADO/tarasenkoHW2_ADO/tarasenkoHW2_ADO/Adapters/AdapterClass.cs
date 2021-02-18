using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using tarasenkoHW2_ADO.Models;
using System.Data;

namespace tarasenkoHW2_ADO.Adapters
{
    public class AdapterClass
    {
        public static string ConnectionString { get; private set; } = ConfigurationManager.ConnectionStrings["PV921"].ConnectionString;

        public static class Customer
        {

            public static List<CustomerModel> ReturnAllCustomers()
            {
                List<CustomerModel> AllCustomers = new List<CustomerModel>();

                try
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();

                        SqlDataAdapter customerAdapter = new SqlDataAdapter("SELECT * FROM [PV921].[dbo].[Customer]", conn);

                        DataSet dbDataSet = new DataSet();
                        customerAdapter.Fill(dbDataSet, "Customer");

                        DataTable customer = dbDataSet.Tables["Customer"];

                        int IDfield;
                        string NameField;
                        string SurnameField;
                        DateTime BirhtField;

                        foreach (DataRow customerRow in customer.Rows)
                        {
                            IDfield = (int)customerRow["CustomerID"];
                            NameField = (string)customerRow["FirstName"];
                            SurnameField = (string)customerRow["LastName"];
                            BirhtField = (DateTime)customerRow["BirthDate"];

                            AllCustomers.Add(new CustomerModel(IDfield, NameField, SurnameField, BirhtField));
                        }

                    }

                    return AllCustomers;
                }
                catch(Exception)
                {
                    Console.WriteLine($"Operation Error!");
                }

                return AllCustomers;
            }

            public static bool AddNewCustomer(CustomerModel newCustomer)
            {
                try
                {
                    using(SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();

                        SqlDataAdapter customerAdapter = new SqlDataAdapter();

                        customerAdapter.InsertCommand = new SqlCommand("dbo.stp_CustomerAdd", conn);
                        customerAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                        customerAdapter.InsertCommand.Parameters.AddWithValue("@FirstName", newCustomer.FirstName);
                        customerAdapter.InsertCommand.Parameters.AddWithValue("@LastName", newCustomer.LastName);
                        customerAdapter.InsertCommand.Parameters.AddWithValue("@BirthDate", newCustomer.BirthDate);
                        customerAdapter.InsertCommand.Parameters.Add("@CustomerID", SqlDbType.Int).Direction = ParameterDirection.Output;
                        customerAdapter.InsertCommand.ExecuteNonQuery();
                    }
                    
                    Console.WriteLine($"New Customer has been added!");
                    return true;
                }
                catch(Exception)
                {
                    Console.WriteLine($"Operation Error!");
                }
                return false;
            }

            public static bool DeleteCustomerByID(int customerToDelete)
            {
                try
                {
                    using(SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();

                        SqlDataAdapter customerAdapter = new SqlDataAdapter("SELECT * FROM [PV921].[dbo].[Customer]", conn);
                        SqlCommandBuilder customerCmdBuilder = new SqlCommandBuilder(customerAdapter);

                        DataSet dbDataSet = new DataSet();

                        customerAdapter.Fill(dbDataSet, "Customer");

                        DataTable customer = dbDataSet.Tables["Customer"];
                        customer.PrimaryKey = new DataColumn[] { customer.Columns["CustomerID"] };

                        DataRow newCustomerRow = customer.NewRow();

                        DataRow userToDelete = customer.Rows.Find(customerToDelete);

                        if (userToDelete != null)
                        {
                            userToDelete.Delete();
                            Console.WriteLine($"Customer with ID {customerToDelete} has been deleted!\n");
                        }
                        else
                            Console.WriteLine($"Customer with ID {customerToDelete} don't exists in the DataBase!\n");

                        customerAdapter.Update(dbDataSet, "Customer");
                    }
                    return true;
                }
                catch(Exception)
                {
                    Console.WriteLine($"Operation Error!\n");
                }
                return false;
            }

            public static CustomerModel GetCustomerByID(int customerID)
            {
                CustomerModel CustomerByID = null;

                try
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();

                        SqlDataAdapter customerAdapter = new SqlDataAdapter("SELECT * FROM [PV921].[dbo].[Customer]", conn);
                        SqlCommandBuilder customerCmdBuilder = new SqlCommandBuilder(customerAdapter);

                        DataSet dbDataSet = new DataSet();

                        customerAdapter.Fill(dbDataSet, "Customer");

                        DataTable customer = dbDataSet.Tables["Customer"];
                        customer.PrimaryKey = new DataColumn[] { customer.Columns["CustomerID"] };

                        DataRow customerByIDRow = customer.NewRow();

                        DataRow userToRead = customer.Rows.Find(customerID);

                        int IDfield;
                        string NameField;
                        string SurnameField;
                        DateTime BirhtField;

                        if (userToRead != null)
                        {
                            IDfield = (int)userToRead["CustomerID"];
                            NameField = (string)userToRead["FirstName"];
                            SurnameField = (string)userToRead["LastName"];
                            BirhtField = (DateTime)userToRead["BirthDate"];

                            CustomerByID = new CustomerModel(IDfield, NameField, SurnameField, BirhtField);
                        }
                        else
                            Console.WriteLine($"Customer with ID {customerID} don't exists in the DataBase!\n");

                    }
                    return CustomerByID;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Operation Error!\n");
                }
                return CustomerByID;
            }

            public static bool CustomerUpdate(CustomerModel customerToUpdate)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();

                        SqlDataAdapter customerAdapter = new SqlDataAdapter("SELECT * FROM [PV921].[dbo].[Customer]", conn);
                        SqlCommandBuilder customerCmdBuilder = new SqlCommandBuilder(customerAdapter);

                        DataSet dbDataSet = new DataSet();

                        customerAdapter.Fill(dbDataSet, "Customer");

                        DataTable customer = dbDataSet.Tables["Customer"];
                        customer.PrimaryKey = new DataColumn[] { customer.Columns["CustomerID"] };

                        DataRow customerUpdateRow = customer.NewRow();

                        DataRow userToUpdate = customer.Rows.Find(customerToUpdate.ID);

                        if (userToUpdate != null)
                        {
                            userToUpdate["FirstName"] = customerToUpdate.FirstName;
                            userToUpdate["LastName"] = customerToUpdate.LastName;
                            userToUpdate["BirthDate"] = customerToUpdate.BirthDate;
                            customerAdapter.Update(dbDataSet, "Customer");

                            Console.WriteLine($"Customer with ID {customerToUpdate.ID} has been updated!");
                        }
                        else
                            Console.WriteLine($"Customer with ID {customerToUpdate.ID} don't exists in the DataBase!\n");
                    }
                    return true;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Operation Error!\n");
                }
                return false;
            }
        }

    }
}
