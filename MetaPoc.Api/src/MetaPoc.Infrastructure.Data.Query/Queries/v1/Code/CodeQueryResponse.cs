namespace MetaPoc.Infrastructure.Data.Query.Queries.v1.Code
{
    public class CodeQueryResponse
    {
        public CodeQueryResponse(string codeLink)
        {
            CodeLink = codeLink;
        }

        public string CodeLink { get; set; }
    }
}