using System.Runtime.InteropServices;
using NUnit.Framework;
using POS.Utilities;

namespace POS.Test
{
    [TestFixture]
    public class TestSound
    {
        
        [Test]
        public void Should_Be_hearing_Sound_Beep_Out_From_Computer()
        {
            Sound.Beep(500, 100);
        }
    }
}
