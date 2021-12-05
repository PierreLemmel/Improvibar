using UnityEngine;

namespace Improvibar.Dmx.Fixtures
{
    public class WhitePanFixture : DmxFixture
    {
        [Range(0x00, 0xff)]
        public int dimmer;

        [Range(0x00, 0xff)]
        public int warm;

        [Range(0x00, 0xff)]
        public int cold;

        [Range(0x00, 0xff)]
        public int stroboscope;

        protected override int GetNumberOfChannels() => 7;

        protected override void UpdateChannels(byte[] channels)
        {
            channels[0] = (byte)dimmer;
            channels[1] = (byte)warm;
            channels[2] = (byte)cold;
            channels[3] = (byte)stroboscope;
        }
    }
}