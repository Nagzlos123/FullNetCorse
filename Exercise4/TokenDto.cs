﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class TokenDto : IBaseDto
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}