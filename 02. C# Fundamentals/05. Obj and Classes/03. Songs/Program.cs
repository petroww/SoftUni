using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] dataSongs = Console.ReadLine()
                .Split("_", StringSplitOptions.RemoveEmptyEntries);
                

                string typeOfMusic = dataSongs[0];
                string name = dataSongs[1];
                string time = dataSongs[2];

                Song song = new Song();

                song.TypeList = typeOfMusic;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeOfList = Console.ReadLine();

            if (typeOfList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeOfList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
        class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }


        }
    }
}
