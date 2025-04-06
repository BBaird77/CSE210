using System;
using System.Collections.Generic;

public class Videomaker {
    public static List<Video> CreateVideos()
    {
            List<Video> videos = new List<Video>();

        Video video1 = new Video("Trope Talk: Silent Protagonists", "Overly Sarcastic Productions", 918);
        video1.AddComment(new Comment("Dave", "Great video, thanks!"));
        video1.AddComment(new Comment("Bob", "Very interesting!"));
        video1.AddComment(new Comment("Jack", "Loved the examples. Thanks for calling out my favorite!"));
        videos.Add(video1);

        Video video2 = new Video("The Living Tombstone - Sunburn", "The Living Tombstone", 252);
        video2.AddComment(new Comment("Steve", "Awesome song!"));
        video2.AddComment(new Comment("Eva", "Amazing work!"));
        video2.AddComment(new Comment("Danielle", "Loved the animation work!"));
        videos.Add(video2);

        Video video3 = new Video("Will Destiny 2 Frontiers Be Delayed?", "Aztecross", 965);
        video3.AddComment(new Comment("Rex", "Man, here's hoping it doesn't."));
        video3.AddComment(new Comment("Dan", "Looking forward to more news either way!"));
        videos.Add(video3);

        return videos;
    }
}