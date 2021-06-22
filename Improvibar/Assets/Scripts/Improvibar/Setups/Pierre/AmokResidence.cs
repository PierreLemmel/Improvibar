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
        #endregion

        protected override void Awake()
        {
            base.Awake();

            lights = FindObjectOfType<PierreLights>();

            SoundboardPage GetPage(int preset) => preset switch
            {
                1 => soundboardPage1,
                2 => soundboardPage2,
                3 => soundboardPage3,
                4 => soundboardPage4,
                _ => throw new InvalidOperationException("Unexpected preset")
            };

            for (int preset = 1; preset <= 4; preset++)
            {
                GameObject presetGo = new GameObject($"Preset_{preset}");
                presetGo.transform.parent = transform;

                GameObject sourcesGo = new GameObject("Sources");
                sourcesGo.transform.parent = presetGo.transform;

                for (int prog = 1; prog <= 8; prog++)
                {
                    GameObject audioSourceGo = new GameObject(AudioSourceName(preset, prog));
                    audioSourceGo.transform.parent = sourcesGo.transform;

                    AudioSource source = audioSourceGo.AddComponent<AudioSource>();
                    source.clip = GetPage(preset).GetClip(prog);
                }
            }
        }

        #region Preset 1
        #region Programs
        public override void Preset1_Program1_Started() => Toggle_Page1_Clip1();
        public override void Preset1_Program2_Started() => Toggle_Page1_Clip2();
        public override void Preset1_Program3_Started() => Toggle_Page1_Clip3();
        public override void Preset1_Program4_Started() => Toggle_Page1_Clip4();
        public override void Preset1_Program5_Started() => Toggle_Page1_Clip5();
        public override void Preset1_Program6_Started() => Toggle_Page1_Clip6();
        public override void Preset1_Program7_Started() => Toggle_Page1_Clip7();
        public override void Preset1_Program8_Started() => Toggle_Page1_Clip8();
        #endregion
        #endregion

        #region Preset 2
        #region Programs
        public override void Preset2_Program1_Started() => Toggle_Page2_Clip1();
        public override void Preset2_Program2_Started() => Toggle_Page2_Clip2();
        public override void Preset2_Program3_Started() => Toggle_Page2_Clip3();
        public override void Preset2_Program4_Started() => Toggle_Page2_Clip4();
        public override void Preset2_Program5_Started() => Toggle_Page2_Clip5();
        public override void Preset2_Program6_Started() => Toggle_Page2_Clip6();
        public override void Preset2_Program7_Started() => Toggle_Page2_Clip7();
        public override void Preset2_Program8_Started() => Toggle_Page2_Clip8();
        #endregion
        #endregion

        #region Preset 3
        #region Toggles
        public override void Preset3_Toggle1_Started() => TurnOnLedJardinCour();
        public override void Preset3_Toggle1_Stopped() => TurnOffLedJardinCour();

        public override void Preset3_Toggle2_Started() => TurnOnFaceJardinCour();
        public override void Preset3_Toggle2_Stopped() => TurnOffFaceJardinCour();

        public override void Preset3_Toggle3_Started() => TurnOnFaceCourJardin();
        public override void Preset3_Toggle3_Stopped() => TurnOffFaceCourJardin();

        public override void Preset3_Toggle4_Started() => TurnOnLedCourJardin();
        public override void Preset3_Toggle4_Stopped() => TurnOffLedCourJardin();
        #endregion

        #region Programs
        public override void Preset3_Program1_Started() => Toggle_Page3_Clip1();
        public override void Preset3_Program2_Started() => Toggle_Page3_Clip2();
        public override void Preset3_Program3_Started() => Toggle_Page3_Clip3();
        public override void Preset3_Program4_Started() => Toggle_Page3_Clip4();
        public override void Preset3_Program5_Started() => Toggle_Page3_Clip5();
        public override void Preset3_Program6_Started() => Toggle_Page3_Clip6();
        public override void Preset3_Program7_Started() => Toggle_Page3_Clip7();
        public override void Preset3_Program8_Started() => Toggle_Page3_Clip8();
        #endregion

        #region Knobs
        public override void Preset3_Knob1_Changed(byte value) => DimAll(value);
        public override void Preset3_Knob3_Changed(byte value) => DimFaces(value);
        public override void Preset3_Knob4_Changed(byte value) => DimLeds(value);

        public override void Preset3_Knob5_Changed(byte value) => DimLedJardinCour(value);
        public override void Preset3_Knob6_Changed(byte value) => DimFaceJardinCour(value);
        public override void Preset3_Knob7_Changed(byte value) => DimFaceCourJardin(value);
        public override void Preset3_Knob8_Changed(byte value) => DimLedCourJardin(value);
        #endregion
        #endregion

        #region Preset 4
        #region Toggles
        public override void Preset4_Toggle1_Started() => TurnOnLedJardinCour();
        public override void Preset4_Toggle1_Stopped() => TurnOffLedJardinCour();

        public override void Preset4_Toggle2_Started() => TurnOnFaceJardinCour();
        public override void Preset4_Toggle2_Stopped() => TurnOffFaceJardinCour();

        public override void Preset4_Toggle3_Started() => TurnOnFaceCourJardin();
        public override void Preset4_Toggle3_Stopped() => TurnOffFaceCourJardin();

        public override void Preset4_Toggle4_Started() => TurnOnLedCourJardin();
        public override void Preset4_Toggle4_Stopped() => TurnOffLedCourJardin(); 
        #endregion

        #region Programs
        public override void Preset4_Program1_Started() => Toggle_Page4_Clip1();
        public override void Preset4_Program2_Started() => Toggle_Page4_Clip2();
        public override void Preset4_Program3_Started() => Toggle_Page4_Clip3();
        public override void Preset4_Program4_Started() => Toggle_Page4_Clip4();
        public override void Preset4_Program5_Started() => Toggle_Page4_Clip5();
        public override void Preset4_Program6_Started() => Toggle_Page4_Clip6();
        public override void Preset4_Program7_Started() => Toggle_Page4_Clip7();
        public override void Preset4_Program8_Started() => Toggle_Page4_Clip8();
        #endregion

        #region Knobs
        public override void Preset4_Knob1_Changed(byte value) => DimAll(value);
        public override void Preset4_Knob3_Changed(byte value) => DimFaces(value);
        public override void Preset4_Knob4_Changed(byte value) => DimLeds(value);

        public override void Preset4_Knob5_Changed(byte value) => DimLedJardinCour(value);
        public override void Preset4_Knob6_Changed(byte value) => DimFaceJardinCour(value);
        public override void Preset4_Knob7_Changed(byte value) => DimFaceCourJardin(value);
        public override void Preset4_Knob8_Changed(byte value) => DimLedCourJardin(value);
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

        private void ToggleClip(int preset, int program)
        {
            //GetComponentsInChildren<AudioSource>
        }
        #endregion

        [Serializable]
        public class SoundboardPage
        {
            public AudioClip clip1;
            public AudioClip clip2;
            public AudioClip clip3;
            public AudioClip clip4;
            public AudioClip clip5;
            public AudioClip clip6;
            public AudioClip clip7;
            public AudioClip clip8;

            public AudioClip GetClip(int program)
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

        private static string AudioSourceName(int preset, int program) => $"Source_Preset{preset}_Program{program}";
    }
}
