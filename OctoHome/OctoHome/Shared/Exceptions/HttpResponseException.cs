using System;
using System.Net;

namespace OctoHome.Shared.Exceptions
{
    public class HttpResponseException : Exception
    {
        public readonly HttpStatusCode StatusCode;

        public HttpResponseException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }

        public HttpResponseException(string message, HttpStatusCode statusCode) : base(message)
        {
            StatusCode = statusCode;
        }

        public HttpResponseException(string message, Exception innerException, HttpStatusCode statusCode) : base(message, innerException)
        {
            StatusCode = statusCode;
        }
    }
}