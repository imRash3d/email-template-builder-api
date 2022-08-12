namespace EmailTemplateBuilder.Api.Commands
{
    public class EmailSendCommand
    {
        public string To { get; set; }
        public string TemplateHtml { get; set; }
    }
}
