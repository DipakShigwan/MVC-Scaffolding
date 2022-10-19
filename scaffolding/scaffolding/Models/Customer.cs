using System.ComponentModel.DataAnnotations;

namespace scaffolding.Models
{
    public class Customer
    {
        [Key]
        public string? CustName { get; set; }
        public string? Address { get; set; }


    }
}
