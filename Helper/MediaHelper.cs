using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Helper
{
    internal static class MediaHelper
    {
        public static string CAR_START = "car-engine-start.wav";
        private static string ASSET_PATH = @"C:\Users\Koolkarkee\source\repos\ConsoleApp1\Assets\";

        public static void PlayAudio(string fileName)
        {
            string path = $"{ASSET_PATH}{fileName}";
            SoundPlayer soundPlayer = new SoundPlayer(path);
            soundPlayer.Play();
        }
    }
}
