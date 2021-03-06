﻿using System.Net;

namespace DEG.ServiceCore.Authentication
{
    public class NoAuthentication : IServiceAuth
    {
        public WebClient GetAuthenticatedWebClient()
        {
            return new WebClient();
        }

        public string GetAuthenticatedUrl(string url)
        {
            return url;
        }
    }
}
