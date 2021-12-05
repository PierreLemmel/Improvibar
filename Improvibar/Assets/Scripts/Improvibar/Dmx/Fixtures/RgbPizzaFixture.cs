using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Improvibar.Dmx.Fixtures
{
    public class RgbPizzaFixture : DmxFixture
    {
        [Range(0x00, 0xff)]
        public int dimmer;

        public Color color = Color.black;

        protected override int GetNumberOfChannels() => 4;

        protected override void UpdateChannels(byte[] channels)
        {
            Color32 color32 = color;

            channels[0] = (byte)dimmer;
            channels[1] = color32.r;
            channels[2] = color32.g;
            channels[3] = color32.b;
        }
    }
}
