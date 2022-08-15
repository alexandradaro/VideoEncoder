namespace Events
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var video = new Video() { Title = "video 1"};
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
    public class MailService //subscriber
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("MailService: Sending a mail...");
        }
    }
}