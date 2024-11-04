namespace Blog_WebApp.DisplayModel
{
    public class GetUserDetailsDto
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string profile_picture { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public int hours_since_created { get; set; }
        public string? DisplayTime {get;set;}
    }
}
