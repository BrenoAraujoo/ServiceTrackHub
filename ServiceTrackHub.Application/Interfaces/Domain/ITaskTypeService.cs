﻿using ServiceTrackHub.Application.InputViewModel.TaskType;
using ServiceTrackHub.Domain.Enums.Common.Result;

namespace ServiceTrackHub.Application.Interfaces
{
    public interface ITaskTypeService
    {
        Task<Result> GetAll();
        Task<Result> GetById(Guid id);
        Task<Result> Create(CreateTaskTypeModel taskTypeModel);
        Task<Result> Update(Guid id, UpdateTaskTypeModel taskTypeInput);
        Task<Result> Delete(Guid id);
    }
}