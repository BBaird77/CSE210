using System;
using System.Collections.Generic;

class Program {
    static void Main()
    {
        List<Video> videos = Videomaker.CreateVideos();

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}\n");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}