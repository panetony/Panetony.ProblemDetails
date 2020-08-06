namespace Panetony.ProblemDetails
{
    public class ProblemDetail
    {
        public string Code { get; private set; }
        public string Title { get; set; }
        public string Detail { get; set; }

        public ProblemDetail(string code)
        {
            Code = code;
        }

        public ProblemDetail(string code, string title = "", string detail = "")
        {
            Code = code;
            Title = title;
            Detail = detail;
        }
    }
}
