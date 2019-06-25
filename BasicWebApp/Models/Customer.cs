using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BasicWebApp.Models
{
    public class Customer
    {
        public string Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage ="Your String is too long!")]
        [DisplayName("Enter Your Name")]
        public string Name { get; set; }
        public string Telephone { get; set; }
    }
}