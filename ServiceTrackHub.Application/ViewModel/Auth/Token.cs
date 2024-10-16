﻿namespace ServiceTrackHub.Application.ViewModel.Auth;

public class Token
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
    public DateTime? Expiration { get; set; }

    public Token(string accessToken, string refreshToken, DateTime expiration)
    {
        AccessToken = accessToken;
        RefreshToken = refreshToken;
        Expiration = expiration;
    }

    public Token(string accessToken, string refreshToken, DateTime? expiration)
    {
        AccessToken = accessToken;
        RefreshToken = refreshToken;
        Expiration = expiration;
    }
}