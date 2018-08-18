using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticeMVC.Models
{
    public class Class1
    {
        [Key]
        public int ClassID { get; set; }
        public string Name { get; set; }
        public int MyAge { get; set; }
    }
}