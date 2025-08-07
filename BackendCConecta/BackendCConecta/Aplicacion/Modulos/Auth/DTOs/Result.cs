using System;

namespace BackendCConecta.Aplicacion.Modulos.Auth.DTOs
{
    public class Result<T>
    {
        public bool Success { get; init; }
        public T? Data { get; init; }
        public string? Error { get; init; }

        public static Result<T> SuccessResult(T data) => new Result<T> { Success = true, Data = data };
        public static Result<T> Failure(string error) => new Result<T> { Success = false, Error = error };
    }
}
