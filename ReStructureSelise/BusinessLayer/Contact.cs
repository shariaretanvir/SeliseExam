using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [MinLength(8)]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string House { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string PoBox { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Zip { get; set; }
    }
}
