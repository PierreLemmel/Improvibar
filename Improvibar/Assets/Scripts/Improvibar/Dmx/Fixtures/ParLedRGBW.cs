using System;
using UnityEngine;

namespace Improvibar.Dmx.Fixtures
{
    public class ParLedRGBW : DmxFixture
    {
        [Range(0x00, 0xff)]
        public int dimmer;

        public Color color = Color.black;

        [Range(0x00, 0xff)]
        public int yellow;

        [Range(0x00, 0xff)]
        public int stroboscope;

        protected override int GetNumberOfChannels() => 8;

        protected override void UpdateChannels(byte[] channels)
        {
            Color32 color32 = color;

            channels[0] = color32.r;
            channels[1] = color32.g;
            channels[2] = color32.b;
            channels[3] = (byte)yellow;
            channels[4] = (byte)dimmer;
            channels[5] = (byte)stroboscope;
        }
    }
}