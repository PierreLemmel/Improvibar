using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Improvibar.Dmx.Fixtures
{
    public class LedBar : DmxFixture
    {
        protected override int GetNumberOfChannels() => 6;

        [Range(0x00, 0xff)]
        public int dimmer;

        [Range(0x00, 0xff)]
        public int warm;

        [Range(0x00, 0xff)]
        public int cold;

        [Range(0x00, 0xff)]
        public int strobe;

        protected override void UpdateChannels(byte[] channels)
        {
            channels[0] = (byte)dimmer;
            channels[1] = (byte)warm;
            channels[2] = (byte)cold;
            channels[5] = (byte)strobe;
        }
    }
}