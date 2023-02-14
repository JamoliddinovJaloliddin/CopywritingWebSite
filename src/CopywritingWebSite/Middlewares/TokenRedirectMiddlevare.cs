﻿namespace CopywritingWebSite.MVS.Middlewares
{
    public class TokenRedirectMiddlevare
    {
        private readonly RequestDelegate _request;

        public TokenRedirectMiddlevare(RequestDelegate request)
        {
            this._request = request;
        }

        public Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Cookies.TryGetValue("X-Access-Token", out var accessToken))
            {
                if (!string.IsNullOrEmpty(accessToken))
                {
                    string token = $"Bearer {accessToken}";
                    context.Request.Headers.Add("Authorization", token);
                }
            }
            return _request(context);
        }
    }
}
