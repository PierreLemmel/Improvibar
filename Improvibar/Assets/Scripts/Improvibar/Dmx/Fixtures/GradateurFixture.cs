using System;
using UnityEngine;

namespace Improvibar.Dmx.Fixtures
{
    public class GradateurFixture : DmxFixture
    {
        [Range(0x00, 0xff)]
        public int value;

        protected override int GetNumberOfChannels() => 1;

        protected override void UpdateChannels(byte[] channels)
        {
            channels[0] = (byte)value;
        }
    }
}