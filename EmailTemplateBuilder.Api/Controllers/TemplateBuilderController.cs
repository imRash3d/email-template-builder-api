using EmailTemplateBuilder.Api.Commands;
using EmailTemplateBuilder.Api.DataContext.Implementations;
using EmailTemplateBuilder.Api.Dtos;
using EmailTemplateBuilder.Api.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailTemplateBuilder.Api.Controllers
{

 
    public class TemplateBuilderController : ApiController
    {
        IOptions<EmailTemplateModel> _options;
      
        public TemplateBuilderController(IOptions<EmailTemplateModel> options)
        {

            _options = options;
     
        }
        [HttpPost("export-json")]
        public async Task<ActionResult<CommandResponse>> ExportJson(ExportJsonDto data)

        {

            CommandResponse response = new CommandResponse();

            try
            {

                var emailTemplate = new EmailTemplateModel()
                {
                    Name = data.Name,
                    TenantId = data.TenantId,
                    MailConfigurationId = data.MailConfigurationId,
                    CreatedBy = data.CreatedBy,
                    TemplateBody = Regex.Escape(data.TemplateBody) ,
                    TemplateSubject = data.TemplateSubject,
                    Language = data.Language,
                    _id = data.ItemId,
                };

                response.Result = emailTemplate;
                response.Success = true;
              //  JsonUtils.WriteJsonFIle(emailTemplate, "data.json");
            }
            catch (Exception ex)
            {


                response.Result = null;
                response.Success = false;
                response.ErrorMessage = JsonConvert.SerializeObject(ex);
            }
            return await Task.FromResult(response);
        }


        [HttpPost("unescape")]
        public async Task<ActionResult<CommandResponse>> Unescape(EscapeUnescapTemplate _template)
        {
            CommandResponse response = new CommandResponse();
            try
            {
                response.Result = Regex.Unescape(_template.TemplateBody);
                response.Success = true;
            }
            catch (Exception ex)
            {


                response.Result = null;
                response.Success = false;
                response.ErrorMessage = JsonConvert.SerializeObject(ex);
            }
            return await Task.FromResult(response);
        }

        [HttpPost("send-mail")]
        public async Task<ActionResult<CommandResponse>> SendMail(EmailSendCommand emailSendCommand)
        {
            CommandResponse response = new CommandResponse();
            try
            {
                MailService.SendMail(emailSendCommand);
                response.Result = null;
                response.Success = true;
            }
            catch (Exception ex)
            {


                response.Result = null;
                response.Success = false;
                response.ErrorMessage = JsonConvert.SerializeObject(ex);
            }
            return await Task.FromResult(response);
        }


    }
}
