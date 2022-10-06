using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //to use DataType

namespace LegacyView.Models
{
    public class DVD
    {
        //properties synchronous with db columns
        public int DVDId { get; set; }
        public string DVDName { get; set; }
        public string DVDGenre { get; set; }
        public string DVDDescription { get; set; }
        public decimal DVDPrice { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string DVDPoster { get; set; }
        public decimal DVDCustomerReview { get; set; }
    }
        
}
