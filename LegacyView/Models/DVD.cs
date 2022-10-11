using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //to use DataType
using System.ComponentModel.DataAnnotations.Schema;

namespace LegacyView.Models
{
    public class DVD
    {
        //properties synchronous with db columns except DVD poster which is a static image
        
        //DVDId is the unique primary key
        public int DVDId { get; set; }

        //Added a screen display name
        [Display(Name = "DVD Name")]
        //added length of string
        [StringLength(60)]
        //Making field required
        [Required]
        public string DVDName { get; set; }

        [Display(Name = "Genre")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")] //RE to only accept letters with first letter uppercase
        [Required]
        public string DVDGenre { get; set; }

        [Display(Name = "Description")]
        //DVDDescription is a short summary about DVD
        public string DVDDescription { get; set; }

        [Display(Name = "Price")]
        //For EF Core to map Price to currency
        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]
        [Required]
        public decimal DVDPrice { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        //DateTime formatting
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Customer Review")]
        //review has precision 2 and scale 1
        [Column(TypeName = "decimal(2, 1)")]
        [Required]
        //Customer Review is based on half point rating
        public decimal DVDCustomerReview { get; set; }

        [Display(Name = "Production Company")]
        [Required]
        public string DVDProductionCompany { get; set; } //added a new property
    }
        
}
