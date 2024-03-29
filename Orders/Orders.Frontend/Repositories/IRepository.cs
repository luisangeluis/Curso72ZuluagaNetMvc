﻿using NPOI.SS.Formula.Functions;

namespace Orders.Frontend.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWrapper<T>> GetAsync(string url);
        Task<HttpResponseWrapper<object>> PostAsync(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PostAsync<T,TActionResponse>(string url);
    }
}