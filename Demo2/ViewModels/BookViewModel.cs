#define Kurwamac

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo2.ViewModels
{
    public class BookViewModel
    {
#if Kurwamac
#else
#endif
        [Required (ErrorMessage ="DAJ PANIE")]
        [RegularExpression(@"\A([0-9]{1})-([0-9]{3})-([0-9]{5})",ErrorMessage ="SPUSC MI SIE NA RYJ")]    
        public string Isbn { get; set; } //
        [Required]
        [MaxLength(40)]
        public string Title { get; set; }
        [Required]
        [MaxLength(50)]
        public string Author { get; set; }
        [Required]
        [MaxLength(30)]
        public string CategoryName { get; set; }
        [Required]
        [EmailAddress]
        public string ContactEmail { get; set; }//
        [Required]
        [Range(0,100)]
        [Display(Name ="Cena")]
        public decimal Price { get; set; } //
        [DataType(DataType.MultilineText)]
        public string Description { get; set; } //
    }
}