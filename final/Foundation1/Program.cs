using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videoList = new List<Video>();

        Video firstVideo = new Video("Stake Conference", "Klein Stake", 7200);
        firstVideo.AddComment(new Comment("Mary", "Best Conference Ever!!"));
        
    }
}