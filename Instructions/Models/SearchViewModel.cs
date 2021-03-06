﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instructions.Models
{
    public class SearchViewModel
    {
        public IQueryable<Record> Records { get; set; }
        public IQueryable<Tag> Tags { get; set; }
        public IQueryable<Step> Steps { get; set; }
        public IQueryable<Comment> Comments { get; set; }
        public string Text { get; set; }
        public bool Success { get; set; }
    }
}
