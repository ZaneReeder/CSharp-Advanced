using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{

    public class Video
    {

    }

    public class Calculator
    {
        public double Divide(int a, int b)
        {
            return a / b;
        }
    }

    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException)
            :base(message, innerException)
        {
            //
        }
    }



    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access Youtube web services
                // Read the data
                // create list of video objects
                throw new Exception("Oops some low level exception.");
            }
            catch (Exception ex)
            {
                // Log
                throw new YouTubeException("Could not fethc the videos from YouTube", ex);
            }

            return new List<Video>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    using (var streamReader = new StreamReader(@"c:\file.zip"))
            //    {
            //        var content = streamReader.ReadToEnd();
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Unexpected error occurred");
            //}
            //finally
            //{
            //    ////IDisposable
            //    //if(streamReader != null)
            //    //    streamReader.Dispose();
            //}

            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("Zane");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
