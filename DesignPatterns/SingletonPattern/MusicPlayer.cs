// Sealed MusicPlayer class, preventing inheritance
public sealed class MusicPlayer
{
    // Private constructor to prevent instantiation from outside
    private MusicPlayer() {}

    // Add private static readonly Lazy<MusicPlayer> instance for thread-safe initialization
    private static readonly Lazy<MusicPlayer> instance = new Lazy<MusicPlayer>(() => new MusicPlayer() );

    // Add public static property to access the single instance
    public static MusicPlayer Instance = instance.Value;

    // Method to play a song
    public void PlaySong(string song)
    {
        Console.WriteLine($"Playing: {song}");
    }
}

class Program
{
    static void Main()
    {
        // Access the MusicPlayer instance and play a song
        MusicPlayer.Instance.PlaySong("Song1.mp3");
    }
}