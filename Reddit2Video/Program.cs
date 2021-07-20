using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using FFMpegSharp.FFMPEG;

namespace Reddit2Video
{
    class Program
    {
        static void Main(string[] args)
        {
            RedditHelper redditHelper = new RedditHelper();
            var redditPostsBodyList = redditHelper.GetSubRedditTopPostsBody("tifu", 5);

            Stream resultStream;

            SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.SetOutputToDefaultAudioDevice();

            synth.SetOutputToWaveFile(@"C:\Users\Timi\source\repos\Reddit2Video\test.wav",
              new SpeechAudioFormatInfo(32000, AudioBitsPerSample.Sixteen, AudioChannel.Mono));

            PromptBuilder builder = new PromptBuilder();
            builder.AppendText(redditPostsBodyList[0]);
            synth.Speak(builder);

            //--------------------------
            //Generate Video from sound

            string inputImage = @"C:\Users\Timi\source\repos\Reddit2Video\Reddit2Video\Images\Untitled.png";
            string inputAudio = @"C:\Users\Timi\source\repos\Reddit2Video\test.wav";
           string outputVideo = @"C:\Users\Timi\source\repos\Reddit2Video\video.mp4";

            FFMpeg encoder = new FFMpeg();

            encoder.PosterWithAudio(new FileInfo(inputImage), new FileInfo(inputAudio), new FileInfo(outputVideo));

            //--------------------
            //Upload video to youtube

            YouTubeHelper youTubeHelper = new YouTubeHelper();
            youTubeHelper.UploadVideo(outputVideo);
        }

      
    }
}
