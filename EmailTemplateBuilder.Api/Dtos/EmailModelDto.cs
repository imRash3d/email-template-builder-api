using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailTemplateBuilder.Api.Dtos
{
    public class EmailTemplateModel
    {
        public string _id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
        public string Language { get; set; }
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;
        public string LastUpdatedBy { get; set; }
        public string[] Tags { get; set; } = new string[1] { "public" };
        public string TenantId { get; set; }
        public string[] RolesAllowedToRead { get; set; } = new string[2] { "Anonymous", "AppUser" };



        public string IdsAllowedToRead { get; set; } = null;
        public string RolesAllowedToWrite { get; set; } = null;
        public string IdsAllowedToWrite { get; set; } = null;
        public string RolesAllowedToUpdate { get; set; } = null;
        public string IdsAllowedToUpdate { get; set; } = null;
        public string RolesAllowedToDelete { get; set; } = null;
        public string IdsAllowedToDelete { get; set; } = null;

        public string MailConfigurationId { get; set; }
        public string Name { get; set; }
        public string TemplateBody { get; set; }
        public string TemplateSubject { get; set; }

    }
}
