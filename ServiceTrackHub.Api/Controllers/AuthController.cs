﻿using Microsoft.AspNetCore.Mvc;
using ServiceTrackHub.Application.InputViewModel.Auth;
using ServiceTrackHub.Application.Interfaces.Auth;
using ServiceTrackHub.Application.Interfaces.Domain;
using ServiceTrackHub.Application.Services.Auth;
using ServiceTrackHub.Application.ViewModel.Auth;
using ServiceTrackHub.Domain.Common.Result;

namespace ServiceTrackHub.Api.Controllers;

[ApiController]
public class AuthController : ApiControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }
    [HttpPost("v1/login")]
    public async Task<IActionResult> Authenticate([FromBody] LoginModel loginModel)
    {
        var  result = await _authService.AuthenticateAsync(loginModel);
        return !result.IsSuccess ? ApiControllerHandleResult(result) : Ok(result);
    }

    [HttpPost("v1/refresh")]
    public async Task<IActionResult> Refresh([FromBody] TokenRequest tokenRequest)
    {
        var result = await _authService.Refresh(tokenRequest);
        return !result.IsSuccess ?  ApiControllerHandleResult(result) : Ok(result);
        
    }
   
}