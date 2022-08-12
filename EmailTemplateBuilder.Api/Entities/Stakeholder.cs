﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailTemplateBuilder.Api.Entities
{
    public class Stakeholder
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        
        public int PhaseId { get; set; }

    }
}
