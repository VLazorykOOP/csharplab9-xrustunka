using System;
using System.Collections;

class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }

    public Song(string title, string artist)
    {
        Title = title;
        Artist = artist;
    }
}

class MusicDisk
{
    public string Title { get; set; }
    protected Hashtable songs = new Hashtable();

    public MusicDisk(string title)
    {
        Title = title;
    }

    public void AddSong(Song song)
    {
        songs.Add(song.Title, song);
    }

    public void RemoveSong(string title)
    {
        songs.Remove(title);
    }

    public void ViewContent()
    {
        Console.WriteLine($"Music Disk: {Title}");
        foreach (DictionaryEntry entry in songs)
        {
            Song song = (Song)entry.Value;
            Console.WriteLine($"Song Title: {song.Title}, Artist: {song.Artist}");
        }
    }

    public ArrayList FindSongsByArtist(string artist)
    {
        ArrayList result = new ArrayList();
        foreach (DictionaryEntry entry in songs)
        {
            Song song = (Song)entry.Value;
            if (song.Artist == artist)
            {
                result.Add(song);
            }
        }
        return result;
    }
}

class MusicCatalog
{
    private Hashtable catalog = new Hashtable();

    public void AddDisk(MusicDisk disk)
    {
        catalog.Add(disk.Title, disk);
    }

    public void RemoveDisk(string title)
    {
        catalog.Remove(title);
    }

    public void ViewCatalogContent()
    {
        Console.WriteLine("Music Catalog:");
        foreach (DictionaryEntry entry in catalog)
        {
            MusicDisk disk = (MusicDisk)entry.Value;
            disk.ViewContent();
        }
    }

    public ArrayList FindSongsByArtist(string artist)
    {
        ArrayList result = new ArrayList();
        foreach (DictionaryEntry entry in catalog)
        {
            MusicDisk disk = (MusicDisk)entry.Value;
            result.AddRange(disk.FindSongsByArtist(artist));
        }
        return result;
    }
}

class Program4
{
    static void Main()
    {
        MusicCatalog catalog = new MusicCatalog();

        // Creating disks and adding songs
        MusicDisk disk1 = new MusicDisk("Disk 1");
        disk1.AddSong(new Song("Song 1", "Artist 1"));
        disk1.AddSong(new Song("Song 2", "Artist 2"));
        catalog.AddDisk(disk1);

        MusicDisk disk2 = new MusicDisk("Disk 2");
        disk2.AddSong(new Song("Song 3", "Artist 1"));
        disk2.AddSong(new Song("Song 4", "Artist 2"));
        catalog.AddDisk(disk2);

        // Viewing catalog and searching for songs by artist
        catalog.ViewCatalogContent();
        string artist = "Artist 1";
        Console.WriteLine($"Songs by artist {artist}:");
        ArrayList searchResult = catalog.FindSongsByArtist(artist);
        foreach (Song song in searchResult)
        {
            Console.WriteLine($"Song Title: {song.Title}");
        }
    }
}
