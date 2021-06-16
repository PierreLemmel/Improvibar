using System;
using UnityEngine;

namespace Improvibar.Dmx.Fixtures
{
    public class TestFixture : DmxFixture
    {
        public int nbOfChannels = 16;

        [Range(0x00, 0xff)]
        public int[] testChannels;

        protected override int GetNumberOfChannels() => nbOfChannels;
        protected override void UpdateChannels(byte[] channels)
        {
            if (testChannels.IsEmpty())
                testChannels = new int[nbOfChannels];

            testChannels.MapTo(channels, chan => (byte)chan);
        }
    }
}