using System;
using System.Threading;

namespace Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // 1- Define a delegate
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        // Delegate type EventHandler<TEventArgs>

        public event EventHandler<VideoEventArgs> VideoEncoded;
        
        // 2- Define an event based on that delegate
        //public event VideoEncodedEventHandler VideoEncoded; //past-tense

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // 3- Raise the event
        // On[name of Event]
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
}