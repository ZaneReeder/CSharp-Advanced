using System;

namespace Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Message Service: Sending Text Message..." + e.Video.Title);
        }
    }

}
