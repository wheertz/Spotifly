namespace Spotifly
{
    internal class Data
    {
        public static List<Song> Songs { get; set; }// = new();
        public static List<Artist> Artists { get; set; } = new();
        public static List<Playlist> Playlists { get; set; } = new();

        public static void AddData()
        {
            Artist a1 = new Artist();
            a1.Name = "Taylor Swift";
            a1.Birthday = new DateTime(1989, 12, 13);
            a1.User = "Jack";
            a1.Country = "USA";
            Artists.Add(a1);

            Artist a2 = new()
            {
                Name = "Pop Smoke",
                Country = "USA",
                Birthday = new DateTime(1999, 6, 20)
            };
            Artists.Add(a2);

            var s1 = new Song()
            {
                Title = "Shake It Off",
                Genre = "´Pop",
                Length = 225,
                ReleaseDate = new DateTime(2014, 8, 19),
                Artists = new List<Artist>() { a1, a2 },
                User = "Fans"
            };

            var s2 = new Song()
            {
                Title = "Dior",
                Genre = "Rap",
                Length = 225,
                ReleaseDate = new DateTime(2019, 6, 26),
                Artists = new List<Artist>() { a1, a2 },
                User = "Fans"
            };

            Songs = new List<Song>();
            Songs.AddRange(new List<Song>(){ s1, s2});

            Playlist p1 = new("Vibes", new List<Song>() { s1, s2 });

            Playlists.Add(p1);
        }
    }
}
