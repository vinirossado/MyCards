namespace MagicAPI.Helper
{
    public class JsonReturnModel
    {

        #region Properties

        public int StatusCode { get; private set; }
        public string Message { get; private set; }

        #endregion Properties

        #region Methods
        public JsonReturnModel(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        #endregion Methods
    }
}
