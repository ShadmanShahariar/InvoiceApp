using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace InvoiceApp.Models
{
    public class InvoiceDetails
    {
        [Required]
        public string Number { get; set; }
        [Required]
        public string Status { get; set; }
        public DateOnly? IssueDate { get; set; }
        public DateOnly? DueDate { get; set; }
        [Required]
        public string Service { get; set; }
        [Range(1,999999,ErrorMessage ="Unit Price is not valid")]
        public decimal UnitPrice { get; set; }
        [Range(1,99)]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Client Name is required")]
        public string ClientName { get; set; } = "";
        [Required, EmailAddress]
        public string Email { get; set; } = "";
        [Phone]
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
