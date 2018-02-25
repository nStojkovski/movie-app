﻿using MoviesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesApp.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genre{ get; set; }
        public Movie Movie { get; set; }
    }
}