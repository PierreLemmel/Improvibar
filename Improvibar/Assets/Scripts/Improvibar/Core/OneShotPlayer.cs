using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Improvibar
{
    public class OneShotPlayer : MonoBehaviour
    {
        private AudioSource source;

        public event EventHandler Finished;

        public void Play(AudioClip clip)
        {
            source = gameObject.AddComponent<AudioSource>();
            source.clip = clip;
            source.Play();
        }

        public void Stop() => source.Stop();

        private void Update()
        {
            if (source.clip != null && !source.isPlaying)
            {
                Finished?.Invoke(this, EventArgs.Empty);
                Finished = null;
                Destroy(gameObject);
            }
        }
    }
}