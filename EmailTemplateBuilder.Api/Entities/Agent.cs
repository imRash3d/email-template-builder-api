﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailTemplateBuilder.Api.Entities
{
    public class Agent
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }

    }
}
