namespace Panetony.ProblemDetails
{
    public class ProblemDetail
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }

        public ProblemDetail()
        {
        }

        public ProblemDetail(string code)
        {
            Code = code;
        }

        public ProblemDetail(string code, string title)
        {
            Code = code;
            Title = title;
        }

        public ProblemDetail(string code, string title, string detail)
        {
            Code = code;
            Title = title;
            Detail = detail;
        }
    }
}
