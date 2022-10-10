using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //to use DataType

namespace LegacyView.Models
{
    public class DVD
    {
        //properties synchronous with db columns except DVD poster which is a static image
        
        //DVDId is the unique primary key
        public int DVDId { get; set; }
        public string DVDName { get; set; }
        public string DVDGenre { get; set; }
        
        //DVDDescription is a short summary about DVD
        public string DVDDescription { get; set; }
        public decimal DVDPrice { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        
        //Customer Review is based on half point rating
        public decimal DVDCustomerReview { get; set; }

        //public string DVDProductionCompany { get; set; } //added a new property
    }
        
}
