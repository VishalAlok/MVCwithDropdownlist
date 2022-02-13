using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
namespace MVC_with_Dropdownlist.Models
{
    public class Employee
    {
        [Required]
        public string Name { get; set; }


        [Required]
        public int Country { get; set; }
    }

    class Country
    {
        public int Id { get; set; }
        public string Text { get; set; }

    }
}