namespace Records
{
    public record Post
    {
        public string Body { get; }
        public RecordsCollection<string> Tags { get; }
        
        public Post(string body, RecordsCollection<string> tags)
            => (Body, Tags) = (body, tags);
    }
}