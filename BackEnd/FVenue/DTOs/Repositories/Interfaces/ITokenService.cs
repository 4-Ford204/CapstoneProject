﻿namespace DTOs.Repositories.Interfaces
{
    public interface ITokenService
    {
        string GetGoogleRequestURL();
        Task<string> GetGoogleAccessToken(string code);
        Task<dynamic> GetGoogleUser(string accessToken);
    }
}
