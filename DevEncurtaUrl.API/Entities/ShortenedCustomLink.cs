namespace DevEncurtaUrl.API.Entities
{
    public class ShortenedCustomLink
    {
        public ShortenedCustomLink(string title, string destinationLink)
        {
            var code = title.Split(" ")[0];

            Title = title;
            DestinationLink = destinationLink;
            ShortenedLink = $"localhost:3000/{code}";
            Code = code;

            CreatedAt = DateTime.Now.ToShortDateString();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortenedLink { get; set; }
        public string DestinationLink { get; set; }
        public string Code { get; set; }
        public string CreatedAt { get; set; }

        internal void Update(string title, string destionationLink)
        {
            Title= title;
            DestinationLink= destionationLink;
        }
    }
}
