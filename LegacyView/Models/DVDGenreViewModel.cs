using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LegacyView.Models
{
    public class DVDGenreViewModel
    {
        public List<DVD> DVDs { get; set; } //list of DVDs
        public SelectList Genres { get; set; } //List of Genres
        public string DvdGenre { get; set; } //name DvdGenre to prevent confusion with DVDGenre from DVD.cs
        public string SearchString { get; set; }
    }
}
