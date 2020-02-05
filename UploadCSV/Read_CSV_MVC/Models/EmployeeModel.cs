using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Read_CSV_MVC.Models
{
    public class EmployeeModel
    {
        ///<summary>
        /// Gets or sets CustomerId.
        ///</summary>
        public int EmployeeId { get; set; }

        ///<summary>
        /// Gets or sets Name.
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// Gets or sets Country.
        ///</summary>
        public string Designation { get; set; }
    }
}