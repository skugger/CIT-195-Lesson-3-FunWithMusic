namespace CIT_195_Lesson_3_FunWithMusic
{
    internal class Program
    {
        enum Genre
        {
            ClassicRock, 
            ProgRock, 
            PunkRock,
            Jazz,
            Classical
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;
            
            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            
            public void setTitle(string title) { 
                Title = title; 
            }
            
            public void setLength(string length) { 
                Length = length; 
            }
            public string Display()
            {
                return "Title = " + Title + "\nArtist = " + Artist + "\nAlbum = " + Album + "\nLength = " + Length + "\nGenre = " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Name the song title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Name the artist: ");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("Name the album the song comes from: ");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("How long is the song? mm:ss");
            string tempLength = Console.ReadLine();
            Console.WriteLine("R = Classic Rock\nG = Prog Rock\nU = Punk Rock\nJ = Jazz\nL = Classical");
            Genre tempGenre = Genre.ClassicRock;
            char s = char.Parse(Console.ReadLine());

            switch(s)
            {
                case 'R':
                    tempGenre = Genre.ClassicRock;
                    break;
                case 'G':
                    tempGenre = Genre.ProgRock;
                    break;
                case 'U':
                    tempGenre = Genre.PunkRock;
                    break;
                case 'J':
                    tempGenre = Genre.Jazz;
                    break;
                case 'L':
                    tempGenre = Genre.Classical;
                    break;
            }
            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);

            Music moreMusic = music;
            Console.WriteLine("Name the next song on the album: ");
            moreMusic.setTitle(Console.ReadLine());
            Console.WriteLine("How long is the song? ");
            moreMusic.setLength(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Here's the first song you entered: ");
            Console.WriteLine($"{music.Display()}");

            Console.WriteLine();
            Console.WriteLine("Here's the second song you entered: ");
            Console.WriteLine($"{moreMusic.Display()}");
        }
    }
}
