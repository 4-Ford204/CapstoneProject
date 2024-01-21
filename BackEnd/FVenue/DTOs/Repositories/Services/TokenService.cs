using DTOs.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace DTOs.Repositories.Services
{
    public class TokenService : ITokenService
    {
        private readonly string host;
        private readonly string googleAuthURL;
        private readonly string redirectURL;
        private readonly string googleTokenURL;
        private readonly string googleUserURL;
        private readonly string googleClientId;
        private readonly string googleClientSecret;
        private readonly string googleRespsoneType;
        private readonly string googleScope;
        private readonly string googleGrantType;

        public TokenService(IConfiguration configuration)
        {
            host = configuration["Host"];
            googleAuthURL = configuration["Google:AuthURL"];
            redirectURL = $"{host}/API/AccountsAPI/GoogleRegistrationHandler";
            googleTokenURL = configuration["Google:TokenURL"];
            googleUserURL = configuration["Google:UserURL"];
            googleClientId = configuration["Google:ClientId"];
            googleClientSecret = configuration["Google:ClientSecret"];
            googleRespsoneType = configuration["Google:ResponseType"];
            googleScope = configuration["Google:Scope"];
            googleGrantType = configuration["Google:GrantType"];
        }

        public string GetGoogleRequestURL()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "client_id", googleClientId },
                { "redirect_uri", redirectURL },
                { "response_type", googleRespsoneType },
                { "scope", googleScope }
            };
            return googleAuthURL + "?" + string.Join("&", parameters.Select(x => $"{x.Key}={x.Value}"));
        }

        public async Task<string> GetGoogleAccessToken(string code)
        {
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("client_id", googleClientId),
                new KeyValuePair<string, string>("client_secret", googleClientSecret),
                new KeyValuePair<string, string>("redirect_uri", redirectURL),
                new KeyValuePair<string, string>("grant_type", googleGrantType),
                new KeyValuePair<string, string>("code", code)
            };
            HttpClient client = new HttpClient();
            var response = await client.PostAsync(googleTokenURL, new FormUrlEncodedContent(parameters));
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                var result = JsonObject.Parse(responseBody);
                return result["access_token"]?.ToString();
            }
            else
                return String.Empty;
        }

        public async Task<dynamic> GetGoogleUser(string accessToken)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var response = await client.GetAsync(googleUserURL);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                dynamic user = JsonSerializer.Deserialize<dynamic>(responseBody);
                return user;
            }
            else
                return null;
        }
    }
}
