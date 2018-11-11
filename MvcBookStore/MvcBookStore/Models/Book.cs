using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBookStore.Models
{
    [Bind(Exclude = "BookId")]
    public class Book
    {
        [ScaffoldColumn(false)]
        public int BookId { get; set; }
        [DisplayName("Kategoria")]
        public int GenreId { get; set; }
        [DisplayName("Autor")]
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "An Author Title is required")]
        [StringLength(160)]
        [DisplayName("Tytuł")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Cena jest wymagana")]
        [Range(0.01, 100.00, ErrorMessage = "Cena musi być z przedziału 0.01 - 100.00")]
        [DisplayName("Cena")]
        public decimal Price { get; set; }
        [DisplayName("Okładka")]
        [StringLength(1024)]
        public string BookArtUrl { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Author Author { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}