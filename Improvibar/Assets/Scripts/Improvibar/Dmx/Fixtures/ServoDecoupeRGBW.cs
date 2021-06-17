using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Improvibar.Dmx.Fixtures
{
    public class ServoDecoupeRGBW : DmxFixture
    {
        [Range(0x00, 0xff)]
        public int pan = 0;

        [Range(0x00, 0xff)]
        public int tilt = 0;

        [Range(0x00, 0xff)]
        public int dimmer = 0;

        public Color color = Color.black;

        [Range(0x00, 0xff)]
        public int white = 0;

        [Range(0x00, 0xff)]
        public int strobe = 0;

        protected override int GetNumberOfChannels() => 12;
        protected override void UpdateChannels(byte[] channels)
        {
            Color32 color32 = color;

            channels[0] = (byte)pan;
            channels[2] = (byte)tilt;
            channels[5] = (byte)dimmer;
            channels[6] = (byte)strobe;
            channels[7] = color32.r;
            channels[8] = color32.g;
            channels[9] = color32.b;
            channels[10] = (byte)white;
        }
    }
}