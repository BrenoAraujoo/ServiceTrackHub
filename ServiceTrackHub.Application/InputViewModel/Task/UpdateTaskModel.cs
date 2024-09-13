﻿using System.ComponentModel.DataAnnotations;

namespace ServiceTrackHub.Application.InputViewModel.Task
{
    public record UpdateTaskModel(
        [
            MinLength(3, ErrorMessage = "O tamanho mínimo do nome da tarefe é 3"),
            MaxLength(100, ErrorMessage = "O tamanho máximo do nome da tarefe é 100")
        ]
        string? Description,
        Guid? UserToId);
}