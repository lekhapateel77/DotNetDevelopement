﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryServices.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Author { get; set; }
        public int PublicationYear { get; set; }
        public bool  IsAvailable { get; set; }
        public string CallNumber { get; set; }

    }
}