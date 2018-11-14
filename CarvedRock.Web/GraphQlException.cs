using System;

namespace CarvedRock.Web
{
    public class GraphQlException: ApplicationException
    {
        public GraphQlException(string message): base(message)
        {
        }
    }
}
