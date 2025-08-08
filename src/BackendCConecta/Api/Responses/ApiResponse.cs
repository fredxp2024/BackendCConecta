namespace BackendCConecta.Api.Responses
{
    public class ApiResponse<T>
    {
        public bool Success { get; init; }
        public T? Data { get; init; }
        public string? Error { get; init; }

        public static ApiResponse<T> SuccessResponse(T data) => new ApiResponse<T> { Success = true, Data = data };
        public static ApiResponse<T> Failure(string error) => new ApiResponse<T> { Success = false, Error = error };
    }
}
