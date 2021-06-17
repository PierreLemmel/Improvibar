using Improvibar.Dmx.Fixtures;
using Improvibar.Dmx.OpenDmx;
using Improvibar.Dmx.OpenDmx.FTD2XX;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Improvibar.Dmx
{
    public class DmxControler : MonoBehaviour
    {
        public GameObject fixturesObject;

        public bool blackout = false;

        [Range(0.0f, 1.0f)]
        public float master = 1.0f;

        [Range(0.0f, 60.0f)]
        public float fade = 0.0f;

        [Range(1.0f, 60.0f)]
        public float refreshRate = 30.0f;

        private DmxFixture[] fixtures;

        private IOpenDmxInterface openDmx = new FTD2XXInterface();

        private byte[] channels;
        private float[] currents;
        private float[] speeds;
        private byte[] targets;

        private float lastTime;

        private void Awake()
        {
            fixtures = fixturesObject.GetComponentsInChildren<DmxFixture>();

            int lastChannel = fixtures.Max(fix => fix.channelOffset + fix.Channels.Length);

            channels = new byte[lastChannel];
            currents = new float[lastChannel];
            speeds = new float[lastChannel];
            targets = new byte[lastChannel];

            lastTime = Time.time;

            openDmx.Start();
        }

        private void OnEnable()
        {
            openDmx.CopyData(channels);
        }

        private void Update()
        {
            if (Time.time - lastTime < 1.0f / refreshRate) return;

            if (!blackout)
            {
                foreach (DmxFixture fixture in fixtures)
                    Array.Copy(fixture.Channels, 0, targets, fixture.channelOffset, fixture.Channels.Length);

                for (int i = 0; i < channels.Length; i++)
                {
                    currents[i] = Mathf.SmoothDamp(currents[i], master * targets[i], ref speeds[i], fade);
                    channels[i] = (byte)currents[i];
                }

                openDmx.CopyData(channels);
                openDmx.SendFrame();
            }
            else
            {
                openDmx.ClearFrame();
                openDmx.SendFrame();
            }


            lastTime = Time.time;
        }

        private void OnDisable()
        {
            openDmx.ClearFrame();
            openDmx.SendFrame();
        }

        private void OnDestroy()
        {
            openDmx.Stop();
            openDmx.Dispose();
        }
    }
}