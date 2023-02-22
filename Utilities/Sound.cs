using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.ComponentModel;

namespace POS.Utilities
{
    public static class Sound
    {
        /// <summary>
        /// Function using for hearing sound from computer system.
        /// </summary>
        /// <param name="BeepFreq">500</param>
        /// <param name="BeepDuration">100</param>
        /// <returns>hearing Beep</returns>
        /// <example>Beep(500,100)</example>
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int BeepFreq, int BeepDuration);
    }
}
