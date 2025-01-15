﻿namespace ServiceTrackHub.Domain.Filters;

public interface IFilterCriteria <T>
{
    IQueryable<T> Apply(IQueryable<T> query);
}