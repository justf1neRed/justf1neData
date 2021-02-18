using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using tarasenkoHW2_ADO.Adapters;
using tarasenkoHW2_ADO.Models;
using tarasenkoHW2_ADO.Entities;
using System.Data.Linq;

namespace tarasenkoHW2_ADO
{
    class Program
    {
        public static string connString = ConfigurationManager.ConnectionStrings["PV921"].ConnectionString;
        public static void ReturnAll()
        {
            List<CustomerModel> allCustomers = AdapterClass.Customer.ReturnAllCustomers();

            foreach (CustomerModel cusModel in allCustomers)
            {
                Console.Write($"{cusModel.ID} {cusModel.FirstName} {cusModel.LastName} {cusModel.BirthDate}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        static void Main(string[] args)

        {
            int userChoise = 0;

            while(userChoise!=0 || true)
            {
                Console.WriteLine("Welcome to HomeWork 2!\nPlease select the operation:\n\n");
                Console.WriteLine("1 - Create the Customer\n2 - Delete the Customer\n3 - Update the Customer\n4 - Read Customer by ID\n5 - Read All Customers\n\n");
                Console.WriteLine("LINQ-to-SQL Operations:\n\n");
                Console.WriteLine("6 - Search by LastName (starts with some letter)\n7 - Search by month of birth\n8 - Search by position\n0 - Exit");

                userChoise = int.Parse(Console.ReadLine());

                if (userChoise == 0) break;

                switch(userChoise)
                {
                    case 1:
                        {
                            Console.Clear();
                            CustomerModel newCust = new CustomerModel("Richard", "Salivan", new DateTime(1995, 02, 10));

                            AdapterClass.Customer.AddNewCustomer(newCust);

                            ReturnAll();
                        }break;
                    case 2:
                        {
                            Console.Clear();
                            AdapterClass.Customer.DeleteCustomerByID(20);

                            ReturnAll();
                        } break;
                    case 3:
                        {
                            Console.Clear();
                            CustomerModel testCust = new CustomerModel(26, "Rice", "Jordan", new DateTime(1998, 04, 15));

                            AdapterClass.Customer.CustomerUpdate(testCust);

                            ReturnAll();
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            CustomerModel testCustomer = AdapterClass.Customer.GetCustomerByID(31);

                            if (testCustomer != null)
                            {
                                Console.WriteLine($"{testCustomer.ID} {testCustomer.FirstName} {testCustomer.LastName} {testCustomer.BirthDate}");
                            }
                        }
                        break;
                    case 5:
                        {
                            Console.Clear();
                            ReturnAll();
                        } break;
                    case 6:
                        {
                            Console.Clear();

                            DataContext db = new DataContext(connString);

                            Table<Employee> employees = db.GetTable<Employee>();

                            var result = employees.Where(e => e.PositionID.Equals(3)).ToList();

                            foreach (Employee item in result)
                            {
                                Console.WriteLine($"{item.EmployeeID} {item.FirstName} {item.LastName}\t{item.BirthDate}\t{item.PositionID}");
                            }

                            Console.ReadKey();
                        } break;
                    case 7:
                        {
                            Console.Clear();

                            DataContext db = new DataContext(connString);

                            Table<Employee> employees = db.GetTable<Employee>();

                            var result = employees.Where(e => e.BirthDate.Month.Equals(02)).ToList();

                            foreach (Employee item in result)
                            {
                                Console.WriteLine($"{item.EmployeeID} {item.FirstName} {item.LastName}\t{item.BirthDate}\t{item.PositionID}");
                            }

                            Console.ReadKey();
                        } break;
                    case 8:
                        {
                            Console.Clear();

                            DataContext db = new DataContext(connString);

                            Table<Employee> employees = db.GetTable<Employee>();

                            var result = employees.Where(e => e.PositionID.Equals(3)).ToList();

                            foreach (Employee item in result)
                            {
                                Console.WriteLine($"{item.EmployeeID} {item.FirstName} {item.LastName}\t{item.BirthDate}\t{item.PositionID}");
                            }

                            Console.ReadKey();
                        } break;
                    default:
                        Console.WriteLine("Wrong number!\n");
                        break;
                }
            }
        }
    }
}
