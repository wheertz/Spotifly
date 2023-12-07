namespace Spotifly
{
    internal class Artist : Stamp
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime Birthday { get; set; }

        public int GetAge()
        {
            return 42;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nCountry: {Country}\nDoB: {Birthday.ToString("yyyy-MM-dd")}\n";
        }
    }
}
