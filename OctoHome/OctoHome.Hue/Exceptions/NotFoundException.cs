using System;
using System.Net;
using OctoHome.Shared.Exceptions;

namespace OctoHome.Hue.Exceptions
{
    public class NotFoundException : HttpResponseException
    {
        public readonly string Id;

        public NotFoundException(string id) : base(HttpStatusCode.NotFound)
        {
            Id = id;
        }

        public NotFoundException(string message, string id) : base(message, HttpStatusCode.NotFound)
        {
            Id = id;
        }

        public NotFoundException(string message, Exception innerException, string id) : base(message, innerException, HttpStatusCode.NotFound)
        {
            Id = id;
        }
    }
}