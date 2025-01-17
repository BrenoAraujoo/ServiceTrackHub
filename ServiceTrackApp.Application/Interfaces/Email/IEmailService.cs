﻿namespace ServiceTrackApp.Application.Interfaces.Email;

public interface IEmailService
{
    Task SendEmailAsync(string email, string subject, string message);
}