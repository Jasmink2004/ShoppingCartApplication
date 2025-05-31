namespace ECommerceApp.DTOs
{
    // Standardized API response structure.
    // T represents the Type of the response data
    public class ApiResponse<T>
    {
        public int StatusCode { get; set; }
        public bool Success { get; set; }

        // Make the Data property required.
        public required T Data { get; set; }

        public List<string> Errors { get; set; }

        public ApiResponse()
        {
            Success = true;
            Errors = new List<string>();
        }

        public ApiResponse(int statusCode, T data)
        {
            StatusCode = statusCode;
            Success = true;
            Data = data;
            Errors = new List<string>();
        }

        public ApiResponse(int statusCode, List<string> errors)
        {
            StatusCode = statusCode;
            Success = false;
            Errors = errors ?? new List<string>();
        }

        public ApiResponse(int statusCode, string error)
        {
            StatusCode = statusCode;
            Success = false;
            Errors = new List<string> { error };
        }

        public void AddError(string error)
        {
            if (Errors == null)
            {
                Errors = new List<string>();
            }
            Errors.Add(error);
        }

        public void AddErrors(List<string> errors)
        {
            if (errors == null) return;
            if (Errors == null)
            {
                Errors = new List<string>();
            }
            Errors.AddRange(errors);
        }
    }

}
