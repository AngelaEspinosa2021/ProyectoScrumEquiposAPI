using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesCompanySystemAPI.Models
{
    public class Customer
    {
        [Key]
        public int id_Customer { get; set; }

        [Required]
        public string customerPhoto { get; set; }

        [Required]
        public int documentType { get; set; }

        [Required]
        public string identificationNumber { get; set; }

        [Required]
        public string nameCustomer { get; set; }

        [Required]
        public string lastNameCustomer { get; set; }

        [Required]
        public string addressCustomer { get; set; }

        [Required]
        public string phoneNumberCustomer { get; set; }

        [Required]
        public string emailCustomer { get; set; }

        [Required]
        public string cityCustomer { get; set; }

    }
}
