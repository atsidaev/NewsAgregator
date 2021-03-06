﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiplomEm.Core
{
    public class News
    {
        
        public virtual int id
        { get; set; }
        public virtual String title
        { get; set; }
        public virtual String url
        { get; set; }
        public virtual String text
        { get; set; }
        public virtual String img
        { get; set; }
        public virtual NewsSource source { get; set;}
    }
}