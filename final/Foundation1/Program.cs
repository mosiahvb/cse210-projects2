using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Programming 101", "Magic programmer", 120);
        video1.AddComment("weird-Al", "This is a great video!");
        video1.AddComment("jake-the-man", "I learned a lot from this video.");
        video1.AddComment("Sandman", "Not bad, but you could've gone into more depth.");

        Video video2 = new Video("How to forge", "The Iron Man", 180);
        video2.AddComment("Timmy-swizzle", "Thank you I hope a lot!");
        video2.AddComment("Zach-attack", "Bro, what you made was awesome!");
        video2.AddComment("Army-of-Helaman1", "That's a great first starter project!");

        Video video3 = new Video("Recording music", "LalaLA21", 150);
        video3.AddComment("Alexio", "You have a beautiful voice great job!");
        video3.AddComment("Strawberry-Sam", "Thank you for your help! You make it look so easy.");
        video3.AddComment("Barnacle-bob", "Not my kind of music, but you have a beautiful voice.");

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine("Commenter: " + comment._name);
                Console.WriteLine("Text: " + comment._text);
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}