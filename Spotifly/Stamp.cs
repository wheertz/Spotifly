namespace Spotifly
{
    internal abstract class Stamp
    {
        public string User { get; set; } = "Anonymous";
        public DateTime TimeCreated { get; set; } = DateTime.Now;
    }
}
