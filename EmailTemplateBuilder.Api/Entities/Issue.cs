using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailTemplateBuilder.Api.Entities
{
    public class Issue
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public string Family { get; set; }
        public string FamilyDivision { get; set; }

    }
}
