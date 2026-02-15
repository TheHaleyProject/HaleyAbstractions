namespace Haley.Abstractions {
    public interface IEmailData {
        string[] To { get; set; }
        string[] CC { get; set; }
        string[] BCC { get; set; }
        string[] ReplyTo { get; set; }
        string Subject { get; set; }
        string Body { get; set; }
        string From { get; set; }
        bool IsHtml { get; set; } 
    }
}
