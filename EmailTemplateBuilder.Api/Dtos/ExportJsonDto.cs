using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailTemplateBuilder.Api.Dtos
{
    public class ExportJsonDto
    {
        public string ItemId { get; set; }
        public string CreatedBy { get; set; }
        public string TenantId { get; set; }
        public string MailConfigurationId { get; set; }
        public string Name { get; set; }
        public string TemplateBody { get; set; }
        public string TemplateSubject { get; set; }
        public string Language { get; set; }


    }
}

