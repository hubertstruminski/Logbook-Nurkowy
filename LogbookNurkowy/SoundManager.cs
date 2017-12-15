using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace LogbookNurkowy
{
    class SoundManager
    {
        public static void PlayWater()
        {
            Play("./dzwieki/nurkowanie_przyciete.wav");
        }

        public static void PlayButton()
        {
            Play("./dzwieki/przycisk.wav");
        }

        private static void Play(string path)
        {
            WaveOutEvent output = new WaveOutEvent();
            WaveFileReader reader = new WaveFileReader(path);
            output.Init(reader);
            output.Play();
        }
    }
}
