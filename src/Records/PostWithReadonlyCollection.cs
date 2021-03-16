using System.Collections.ObjectModel;

namespace Records
{
    public class PostWithReadonlyCollection
    {
        public string Body { get; }
        public ReadOnlyCollection<string> Tags { get; }
        
        public PostWithReadonlyCollection(string body, ReadOnlyCollection<string> tags)
            => (Body, Tags) = (body, tags);
    }
}