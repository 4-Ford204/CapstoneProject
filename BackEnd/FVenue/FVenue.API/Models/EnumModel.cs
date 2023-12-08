namespace FVenue.API.Models
{
    public class EnumModel
    {
        public enum ResultCode
        {
            // 1xx Informational Response
            Continue = 100,
            SwitchingProtocols = 101,
            // 2xx Success
            OK = 200,
            // 3xx Redirection
            // 4xx Client Errors
            BadRequest = 400,
            Unauthorized = 401,
            Forbidden = 403,
            NotFound = 404,
            // 5xx Server Errors
            InternalServerError = 500,
        }
    }
}
