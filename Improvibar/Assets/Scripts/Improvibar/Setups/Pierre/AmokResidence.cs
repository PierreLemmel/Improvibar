using Improvibar.Shows;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Improvibar.Shows
{
    public class AmokResidence : ImprovibarShow
    {
        private PierreLights lights;

        #region Soundboard Page
        [SerializeField, HideInPlayMode]
        private SoundboardPage soundboardPage1;

        [SerializeField, HideInPlayMode]
        private SoundboardPage soundboardPage2;

        [SerializeField, HideInPlayMode]
        private SoundboardPage soundboardPage3;

        [SerializeField, HideInPlayMode]
        private SoundboardPage soundboardPage4;

        private SoundboardPage GetPage(int preset) => preset switch
        {
            1 => soundboardPage1,
            2 => soundboardPage2,
            3 => soundboardPage3,
            4 => soundboardPage4,
            _ => throw new InvalidOperationException("Unexpected preset")
        };
        #endregion

        #region Colors
        [SerializeField, HideInPlayMode]
        private ColorSetup colorSetup1;

        [SerializeField, HideInPlayMode]
        private ColorSetup colorSetup2;

        [SerializeField, HideInPlayMode]
        private ColorSetup colorSetup3;

        [SerializeField, HideInPlayMode]
        private ColorSetup colorSetup4;
        #endregion

        private GameObject sourcesGO;
        protected override void Awake()
        {
            base.Awake();

            lights = FindObjectOfType<PierreLights>();

            sourcesGO = new GameObject("AudioSources");
            sourcesGO.transform.parent = transform;
        }

        #region Preset 1
        public override void Preset1_Program1_Started() => Toggle_Page1_Clip1();
        public override void Preset1_Program2_Started() => Toggle_Page1_Clip2();
        public override void Preset1_Program3_Started() => Toggle_Page1_Clip3();
        public override void Preset1_Program4_Started() => Toggle_Page1_Clip4();
        public override void Preset1_Program5_Started() => Toggle_Page1_Clip5();
        public override void Preset1_Program6_Started() => Toggle_Page1_Clip6();
        public override void Preset1_Program7_Started() => Toggle_Page1_Clip7();
        public override void Preset1_Program8_Started() => Toggle_Page1_Clip8();
        #endregion

        #region Preset 2
        public override void Preset2_Program1_Started() => Toggle_Page2_Clip1();
        public override void Preset2_Program2_Started() => Toggle_Page2_Clip2();
        public override void Preset2_Program3_Started() => Toggle_Page2_Clip3();
        public override void Preset2_Program4_Started() => Toggle_Page2_Clip4();
        public override void Preset2_Program5_Started() => Toggle_Page2_Clip5();
        public override void Preset2_Program6_Started() => Toggle_Page2_Clip6();
        public override void Preset2_Program7_Started() => Toggle_Page2_Clip7();
        public override void Preset2_Program8_Started() => Toggle_Page2_Clip8();
        #endregion

        #region Preset 3
        public override void Preset3_Program1_Started() => Toggle_Page3_Clip1();
        public override void Preset3_Program2_Started() => Toggle_Page3_Clip2();
        public override void Preset3_Program3_Started() => Toggle_Page3_Clip3();
        public override void Preset3_Program4_Started() => Toggle_Page3_Clip4();
        public override void Preset3_Program5_Started() => Toggle_Page3_Clip5();
        public override void Preset3_Program6_Started() => Toggle_Page3_Clip6();
        public override void Preset3_Program7_Started() => Toggle_Page3_Clip7();
        public override void Preset3_Program8_Started() => Toggle_Page3_Clip8();
        #endregion

        #region Preset 4
        public override void Preset4_Program1_Started() => Toggle_Page4_Clip1();
        public override void Preset4_Program2_Started() => Toggle_Page4_Clip2();
        public override void Preset4_Program3_Started() => Toggle_Page4_Clip3();
        public override void Preset4_Program4_Started() => Toggle_Page4_Clip4();
        public override void Preset4_Program5_Started() => Toggle_Page4_Clip5();
        public override void Preset4_Program6_Started() => Toggle_Page4_Clip6();
        public override void Preset4_Program7_Started() => Toggle_Page4_Clip7();
        public override void Preset4_Program8_Started() => Toggle_Page4_Clip8();
        #endregion

        #region Presets All
        #region Toggles
        public override void AllPresets_Toggle1_Started() => TurnOnLedJardinCour();
        public override void AllPresets_Toggle1_Stopped() => TurnOffLedJardinCour();

        public override void AllPresets_Toggle2_Started() => TurnOnFaceJardinCour();
        public override void AllPresets_Toggle2_Stopped() => TurnOffFaceJardinCour();

        public override void AllPresets_Toggle3_Started() => TurnOnFaceCourJardin();
        public override void AllPresets_Toggle3_Stopped() => TurnOffFaceCourJardin();

        public override void AllPresets_Toggle4_Started() => TurnOnLedCourJardin();
        public override void AllPresets_Toggle4_Stopped() => TurnOffLedCourJardin();

        public override void AllPresets_Toggle5_Started() => SetupColor1();
        public override void AllPresets_Toggle5_Stopped() => ClearColors();

        public override void AllPresets_Toggle6_Started() => SetupColor2();
        public override void AllPresets_Toggle6_Stopped() => ClearColors();

        public override void AllPresets_Toggle7_Started() => SetupColor3();
        public override void AllPresets_Toggle7_Stopped() => ClearColors();

        public override void AllPresets_Toggle8_Started() => SetupColor4();
        public override void AllPresets_Toggle8_Stopped() => ClearColors();
        #endregion

        #region Knobs
        public override void AllPresets_Knob1_Changed(byte value) => DimAll(value);
        public override void AllPresets_Knob3_Changed(byte value) => DimFaces(value);
        public override void AllPresets_Knob4_Changed(byte value) => DimLeds(value);

        public override void AllPresets_Knob5_Changed(byte value) => DimLedJardinCour(value);
        public override void AllPresets_Knob6_Changed(byte value) => DimFaceJardinCour(value);
        public override void AllPresets_Knob7_Changed(byte value) => DimFaceCourJardin(value);
        public override void AllPresets_Knob8_Changed(byte value) => DimLedCourJardin(value);
        #endregion
        #endregion

        #region Functions
        private void TurnOnLedJardinCour() => lights.dimmerLedJardinCour = 0xff;
        private void TurnOffLedJardinCour() => lights.dimmerLedJardinCour = 0x00;

        private void TurnOnFaceJardinCour() => lights.jardinCour = 0xff;
        private void TurnOffFaceJardinCour() => lights.jardinCour = 0x00;

        private void TurnOnFaceCourJardin() => lights.courJardin = 0xff;
        private void TurnOffFaceCourJardin() => lights.courJardin = 0x00;

        private void TurnOnLedCourJardin() => lights.dimmerLedCourJardin = 0xff;
        private void TurnOffLedCourJardin() => lights.dimmerLedCourJardin = 0x00;

        private void SetupColor1() => SetupColors(colorSetup1);
        private void SetupColor2() => SetupColors(colorSetup2);
        private void SetupColor3() => SetupColors(colorSetup3);
        private void SetupColor4() => SetupColors(colorSetup4);

        private void SetupColors(ColorSetup setup)
        {
            lights.coldFaces = setup.cold;
            lights.warmFaces = setup.warm;

            lights.ledsColor = setup.ledsColor;
            lights.ledJardinCourColor = setup.ledJardinCourColor;
            lights.ledCourJardinColor = setup.ledCourJardinColor;
        }

        private void ClearColors()
        {
            lights.coldFaces = 0x00;
            lights.warmFaces = 0x00;

            lights.ledsColor = Color.black;
            lights.ledJardinCourColor = Color.black;
            lights.ledCourJardinColor = Color.black;
        }

        

        private void DimAll(byte value) => lights.dimmerAll = MidiToDmx(value);
        private void DimFaces(byte value) => lights.dimmerFaces = MidiToDmx(value);
        private void DimLeds(byte value) => lights.dimmerLeds = MidiToDmx(value);

        private void DimLedJardinCour(byte value) => lights.dimmerLedJardinCour = MidiToDmx(value);
        private void DimFaceJardinCour(byte value) => lights.jardinCour = MidiToDmx(value);
        private void DimFaceCourJardin(byte value) => lights.courJardin = MidiToDmx(value);
        private void DimLedCourJardin(byte value) => lights.dimmerLedCourJardin = MidiToDmx(value);

        private void Toggle_Page1_Clip1() => ToggleClip(1, 1);
        private void Toggle_Page1_Clip2() => ToggleClip(1, 2);
        private void Toggle_Page1_Clip3() => ToggleClip(1, 3);
        private void Toggle_Page1_Clip4() => ToggleClip(1, 4);
        private void Toggle_Page1_Clip5() => ToggleClip(1, 5);
        private void Toggle_Page1_Clip6() => ToggleClip(1, 6);
        private void Toggle_Page1_Clip7() => ToggleClip(1, 7);
        private void Toggle_Page1_Clip8() => ToggleClip(1, 8);

        private void Toggle_Page2_Clip1() => ToggleClip(2, 1);
        private void Toggle_Page2_Clip2() => ToggleClip(2, 2);
        private void Toggle_Page2_Clip3() => ToggleClip(2, 3);
        private void Toggle_Page2_Clip4() => ToggleClip(2, 4);
        private void Toggle_Page2_Clip5() => ToggleClip(2, 5);
        private void Toggle_Page2_Clip6() => ToggleClip(2, 6);
        private void Toggle_Page2_Clip7() => ToggleClip(2, 7);
        private void Toggle_Page2_Clip8() => ToggleClip(2, 8);

        private void Toggle_Page3_Clip1() => ToggleClip(3, 1);
        private void Toggle_Page3_Clip2() => ToggleClip(3, 2);
        private void Toggle_Page3_Clip3() => ToggleClip(3, 3);
        private void Toggle_Page3_Clip4() => ToggleClip(3, 4);
        private void Toggle_Page3_Clip5() => ToggleClip(3, 5);
        private void Toggle_Page3_Clip6() => ToggleClip(3, 6);
        private void Toggle_Page3_Clip7() => ToggleClip(3, 7);
        private void Toggle_Page3_Clip8() => ToggleClip(3, 8);

        private void Toggle_Page4_Clip1() => ToggleClip(4, 1);
        private void Toggle_Page4_Clip2() => ToggleClip(4, 2);
        private void Toggle_Page4_Clip3() => ToggleClip(4, 3);
        private void Toggle_Page4_Clip4() => ToggleClip(4, 4);
        private void Toggle_Page4_Clip5() => ToggleClip(4, 5);
        private void Toggle_Page4_Clip6() => ToggleClip(4, 6);
        private void Toggle_Page4_Clip7() => ToggleClip(4, 7);
        private void Toggle_Page4_Clip8() => ToggleClip(4, 8);

        private static byte MidiToDmx(byte midi) => (byte)(2 * midi);

        private IDictionary<(int preset, int program), OneShotPlayer> playersCache = new Dictionary<(int preset, int program), OneShotPlayer>();
        private void ToggleClip(int preset, int program)
        {
            (int, int) key = (preset, program);
            if (playersCache.TryGetValue(key, out OneShotPlayer player))
            {
                player.Stop();
            }
            else
            {
                SoundboardSound soundboardSound = GetPage(preset).GetClip(program);
                AudioClip clip = soundboardSound.clips.RandomElementOrDefault();
                if (clip == null)
                {
                    Debug.Log($"No clip found on program {program} for preset {preset}");
                    return;
                }

                GameObject go = new GameObject($"Source_Preset{preset}_Program{program}");
                go.transform.parent = sourcesGO.transform;

                OneShotPlayer newPlayer = go.AddComponent<OneShotPlayer>();

                if (soundboardSound.stopOnClick)
                    playersCache.Add(key, newPlayer);

                newPlayer.Finished += (s, e) => playersCache.Remove(key);
                newPlayer.Play(clip);
            }
        }
        #endregion

        [Serializable]
        public class SoundboardPage
        {
            public SoundboardSound clip1;
            public SoundboardSound clip2;
            public SoundboardSound clip3;
            public SoundboardSound clip4;
            public SoundboardSound clip5;
            public SoundboardSound clip6;
            public SoundboardSound clip7;
            public SoundboardSound clip8;

            public SoundboardSound GetClip(int program)
            {
                return program switch
                {
                    1 => clip1,
                    2 => clip2,
                    3 => clip3,
                    4 => clip4,
                    5 => clip5,
                    6 => clip6,
                    7 => clip7,
                    8 => clip8,
                    _ => throw new InvalidOperationException("Unexpected program")
                };
            }
        }

        [Serializable]
        public class SoundboardSound
        {
            public string displayName;
            public AudioClip[] clips = Array.Empty<AudioClip>();
            public bool stopOnClick = true;
            public SoundboardSoundMode Mode = SoundboardSoundMode.Random;

            private int sequenceIndex = 0;

            public AudioClip GetClip() => Mode switch
            {
                SoundboardSoundMode.Random => clips.RandomElementOrDefault(),
                SoundboardSoundMode.Sequence => clips[sequenceIndex++ % clips.Length],
                _ => throw new InvalidOperationException($"Unexpected mode: {Mode}")
            };

            public enum SoundboardSoundMode
            {
                Random,
                Sequence
            }
        }

        [Serializable]
        public class ColorSetup
        {
            [Range(0x00, 0xff)]
            public int cold;

            [Range(0x00, 0xff)]
            public int warm;

            public Color ledsColor = Color.black;
            public Color ledJardinCourColor = Color.black;
            public Color ledCourJardinColor = Color.black;
        }
    }
}
