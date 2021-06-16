using System;

namespace Improvibar.Dmx.OpenDmx
{
    public interface IOpenDmxInterface : IDisposable
    {
        void Start();
        void Stop();

        void SendFrame();
        void ClearFrame();
        void CopyData(int channelOffset, byte[] data, int length);
    }
}