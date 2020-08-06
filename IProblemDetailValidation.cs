using System.Collections.Generic;

namespace Panetony.ProblemDetails
{
    public interface IProblemDetailValidation
    {
        void Add(string code, string title = "", string detail = "");
        int Count();
        bool HasMessage();
        IList<ProblemDetail> Value();
    }
}
