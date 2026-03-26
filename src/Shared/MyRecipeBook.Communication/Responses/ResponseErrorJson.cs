namespace MyRecipeBook.Communication.Responses
{
    public class ResponseErrorJson
    {
        public IList<string> Erros { get; set; }
        public ResponseErrorJson(IList<string> erros) => Erros = erros;


        public ResponseErrorJson(string error)
        {
            Erros = [error];

        }

    }
}
