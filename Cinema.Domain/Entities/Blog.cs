﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Entities
{
    public class Blog : BaseClass
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual User Author { get; set; }
    }
}
