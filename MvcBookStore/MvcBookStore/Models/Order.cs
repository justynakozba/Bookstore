using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBookStore.Models
{
    [Bind(Exclude = "OrderId")]
    public class Order
    {
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }
        [ScaffoldColumn(false)]
        [DisplayName("Nazwa użytkownika")]
        public string Username { get; set; }
        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }
        [Required(ErrorMessage = "Imię jest wymagane")]
        [DisplayName("Imię")]
        [StringLength(160)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [DisplayName("Nazwisko")]
        [StringLength(160)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Adres jest wymagany")]
        [StringLength(70)]
        [DisplayName("Adres")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Miasto jest wymagane")]
        [StringLength(40)]
        [DisplayName("Miasto")]
        public string City { get; set; }
        [Required(ErrorMessage = "Województwo jest wymagane")]
        [StringLength(40)]
        [DisplayName("Województwo")]
        public string State { get; set; }
        [Required(ErrorMessage = "Kod pocztowy jest wymagany")]
        [DisplayName("Kod pocztowy")]
        [StringLength(10)]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Kraj jest wymagany")]
        [StringLength(40)]
        [DisplayName("Kraj")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Telefon jest wymagany")]
        [StringLength(24)]
        [DisplayName("Telefon")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Adres e-mail jes wymagany")]
        [DisplayName("Adres e-mail")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
        ErrorMessage = "Adres e-mail jest nieprawidłowy")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        [DisplayName("Suma")]
        public decimal Total { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}