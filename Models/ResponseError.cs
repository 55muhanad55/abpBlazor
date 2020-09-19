namespace Web.Blazor.Models
{
    public class ResponseError
    {
        public int code { get; set; }
        public string message { get; set; }
        public string details { get; set; }
        public string validationErrors { get; set; }
    }
}
