namespace MonkeyCards.Models
{
    public class Monkey
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}