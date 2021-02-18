using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace tarasenkoHW2_ADO.Entities
{
    [Table(Name = "Employee")]
    public class Employee
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int EmployeeID { get; set; }

        [Column]
        public string FirstName { get; set; }

        [Column(CanBeNull = true)]
        public string LastName { get; set; }

        [Column]
        public DateTime BirthDate { get; set; }

        [Column(CanBeNull = true)]
        public int PositionID { get; set; }
    }
}
