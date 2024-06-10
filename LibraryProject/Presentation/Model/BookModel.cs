﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model
{
    public class BookModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        public BookModel( string id, string title, string author, string genre)
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
        }


    }
}