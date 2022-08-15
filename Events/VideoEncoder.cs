using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class VideoEncoder //publisher
    {
        
        //Creating a delegate
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        // creating an event based on above delegate
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video before sending...");
            Thread.Sleep(1000);
            OnVideoEncoded();
        }
        //raise event
        protected virtual void OnVideoEncoded()
        {
            // if the subscribers to publisher are not null
            if (VideoEncoded != null)   
                VideoEncoded(this, EventArgs.Empty);
        }

    }
    public class Video
    {
        public string Title { get; set; }
    }


}
