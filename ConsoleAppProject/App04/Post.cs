﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.App04
{
    public class Post
    {
        public string Author { get; set; }
        public DateTime Timestamp { get; set; }
        private int likes;
        private readonly List<String> comments;
    }
}
