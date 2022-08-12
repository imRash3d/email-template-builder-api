﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailTemplateBuilder.Api.Entities
{
    public class MailConfiguration
    {
        public int Id { get; set; }
        public string MailConfigurationId { get; set; }
        public string Host { get; set; }
        public string MailAccountPassword { get; set; }
        public string MailSenderAddress { get; set; }
        public string MailSenderUserName { get; set; }
        public int Port { get; set; }
    }
}
