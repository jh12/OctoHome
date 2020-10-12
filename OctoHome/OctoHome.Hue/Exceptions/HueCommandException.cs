using System;
using System.Net;
using OctoHome.Shared.Exceptions;

namespace OctoHome.Hue.Exceptions
{
    public class HueCommandException : HttpResponseException
    {
        public HueCommandException(HttpStatusCode statusCode) : base(statusCode)
        {
        }

        public HueCommandException(string message, HttpStatusCode statusCode) : base(message, statusCode)
        {
        }

        public HueCommandException(string message, Exception innerException, HttpStatusCode statusCode) : base(message, innerException, statusCode)
        {
        }
    }
}