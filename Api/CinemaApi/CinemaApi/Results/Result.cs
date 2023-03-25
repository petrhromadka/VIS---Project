namespace CinemaApi.Results
{
    public class Result
    {
        public bool HasError { get; set; } = false;
        public string? Message { get; set; }
        public string? Outcome { get; set; }
    }
}

