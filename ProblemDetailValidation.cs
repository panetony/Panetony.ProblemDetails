using System.Collections.Generic;

namespace Panetony.ProblemDetails
{
    public class ProblemDetailValidation : IProblemDetailValidation
    {
        private IList<ProblemDetail> _listOfProblemDetail = new List<ProblemDetail>();

        public ProblemDetailValidation()
        {
        }
        public ProblemDetailValidation(ProblemDetail ProblemDetail)
        {
            _listOfProblemDetail.Add(ProblemDetail);
        }
        public ProblemDetailValidation(string code, string title = "", string detail = "")
        {
            _listOfProblemDetail.Add(new ProblemDetail(code, title, detail));
        }
        public void Add(string code, string title = "", string detail = "")
        {
            _listOfProblemDetail.Add(new ProblemDetail(code, title, detail));
        }
        public int Count()
        {
            return _listOfProblemDetail.Count;
        }
        public bool HasMessage()
        {
            return Count() > 0;
        }
        public IList<ProblemDetail> Value()
        {
            return _listOfProblemDetail;
        }
    }
}
