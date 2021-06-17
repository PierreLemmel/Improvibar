using Improvibar.Dmx.Fixtures;
using Improvibar.Shows;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Improvibar.Banal
{
    public class Banal : ImprovibarShow
    {
        private ImprovibarLights lights;

        protected override void Awake()
        {
            base.Awake();

            lights = FindObjectOfType<ImprovibarLights>();
        }

        #region Preset1
        #region Toggles
        public override void Preset1_Toggle1_Started() { }
        public override void Preset1_Toggle1_Stopped() { }

        public override void Preset1_Toggle2_Started() { }
        public override void Preset1_Toggle2_Stopped() { }

        public override void Preset1_Toggle3_Started() { }
        public override void Preset1_Toggle3_Stopped() { }

        public override void Preset1_Toggle4_Started() { }
        public override void Preset1_Toggle4_Stopped() { }

        public override void Preset1_Toggle5_Started() { }
        public override void Preset1_Toggle5_Stopped() { }

        public override void Preset1_Toggle6_Started() { }
        public override void Preset1_Toggle6_Stopped() { }

        public override void Preset1_Toggle7_Started() { }
        public override void Preset1_Toggle7_Stopped() { }

        public override void Preset1_Toggle8_Started() { }
        public override void Preset1_Toggle8_Stopped() { }
        #endregion


        #region Knobs
        public override void Preset1_Knob1_Changed(byte value) { }
        public override void Preset1_Knob2_Changed(byte value) { }
        public override void Preset1_Knob3_Changed(byte value) { }
        public override void Preset1_Knob4_Changed(byte value) { }
        public override void Preset1_Knob5_Changed(byte value) { }
        public override void Preset1_Knob6_Changed(byte value) { }
        public override void Preset1_Knob7_Changed(byte value) { }
        public override void Preset1_Knob8_Changed(byte value) { }
        #endregion


        #region Programs
        public override void Preset1_Program1_Started() { }
        public override void Preset1_Program2_Started() { }
        public override void Preset1_Program3_Started() { }
        public override void Preset1_Program4_Started() { }
        public override void Preset1_Program5_Started() { }
        public override void Preset1_Program6_Started() { }
        public override void Preset1_Program7_Started() { }
        public override void Preset1_Program8_Started() { }
        #endregion 
        #endregion

        #region Preset2
        #region Toggles
        public override void Preset2_Toggle1_Started() { }
        public override void Preset2_Toggle1_Stopped() { }

        public override void Preset2_Toggle2_Started() { }
        public override void Preset2_Toggle2_Stopped() { }

        public override void Preset2_Toggle3_Started() { }
        public override void Preset2_Toggle3_Stopped() { }

        public override void Preset2_Toggle4_Started() { }
        public override void Preset2_Toggle4_Stopped() { }

        public override void Preset2_Toggle5_Started() { }
        public override void Preset2_Toggle5_Stopped() { }

        public override void Preset2_Toggle6_Started() { }
        public override void Preset2_Toggle6_Stopped() { }

        public override void Preset2_Toggle7_Started() { }
        public override void Preset2_Toggle7_Stopped() { }

        public override void Preset2_Toggle8_Started() { }
        public override void Preset2_Toggle8_Stopped() { }
        #endregion


        #region Knobs
        public override void Preset2_Knob1_Changed(byte value) { }
        public override void Preset2_Knob2_Changed(byte value) { }
        public override void Preset2_Knob3_Changed(byte value) { }
        public override void Preset2_Knob4_Changed(byte value) { }
        public override void Preset2_Knob5_Changed(byte value) { }
        public override void Preset2_Knob6_Changed(byte value) { }
        public override void Preset2_Knob7_Changed(byte value) { }
        public override void Preset2_Knob8_Changed(byte value) { }
        #endregion


        #region Programs
        public override void Preset2_Program1_Started() { }
        public override void Preset2_Program2_Started() { }
        public override void Preset2_Program3_Started() { }
        public override void Preset2_Program4_Started() { }
        public override void Preset2_Program5_Started() { }
        public override void Preset2_Program6_Started() { }
        public override void Preset2_Program7_Started() { }
        public override void Preset2_Program8_Started() { }
        #endregion 
        #endregion

        #region Preset3
        #region Toggles
        public override void Preset3_Toggle1_Started() => TurnOnContre1();
        public override void Preset3_Toggle1_Stopped() => TurnOffContre1();

        public override void Preset3_Toggle2_Started() => TurnOnContre2();
        public override void Preset3_Toggle2_Stopped() => TurnOffContre2();

        public override void Preset3_Toggle3_Started() => TurnOnContre3();
        public override void Preset3_Toggle3_Stopped() => TurnOffContre3();

        public override void Preset3_Toggle4_Started() => TurnOnContre4();
        public override void Preset3_Toggle4_Stopped() => TurnOffContre4();

        public override void Preset3_Toggle5_Started() => TurnOnLedJardinCour();
        public override void Preset3_Toggle5_Stopped() => TurnOffLedJardinCour();

        public override void Preset3_Toggle6_Started() => TurnOnServoFace();
        public override void Preset3_Toggle6_Stopped() => TurnOffServoFace();

        public override void Preset3_Toggle7_Started() => TurnOnServoCenter();
        public override void Preset3_Toggle7_Stopped() => TurnOffServoCenter();

        public override void Preset3_Toggle8_Started() => TurnOnLedCourJardin();
        public override void Preset3_Toggle8_Stopped() => TurnOffLedCourJardin();
        #endregion

        #region Knobs
        public override void Preset3_Knob1_Changed(byte value) => SetFade(value);
        public override void Preset3_Knob2_Changed(byte value) => SetLedDimmer(value);
        public override void Preset3_Knob3_Changed(byte value) => SetFacesDimmer(value);
        public override void Preset3_Knob4_Changed(byte value) => SetContresDimmer(value);
        public override void Preset3_Knob5_Changed(byte value) => SetServoFacePan(value);
        public override void Preset3_Knob6_Changed(byte value) => SetServoFaceTilt(value);
        public override void Preset3_Knob7_Changed(byte value) => SetServoCenterPan(value);
        public override void Preset3_Knob8_Changed(byte value) => SetServoCenterTilt(value);
        #endregion

        #region Programs
        public override void Preset3_Program1_Started() { }
        public override void Preset3_Program2_Started() { }
        public override void Preset3_Program3_Started() { }
        public override void Preset3_Program4_Started() { }
        public override void Preset3_Program5_Started() { }
        public override void Preset3_Program6_Started() { }
        public override void Preset3_Program7_Started() { }
        public override void Preset3_Program8_Started() { }
        #endregion 
        #endregion

        #region Preset4
        #region Toggles
        public override void Preset4_Toggle1_Started() => TurnOnContre1();
        public override void Preset4_Toggle1_Stopped() => TurnOffContre1();

        public override void Preset4_Toggle2_Started() => TurnOnContre2();
        public override void Preset4_Toggle2_Stopped() => TurnOffContre2();

        public override void Preset4_Toggle3_Started() => TurnOnContre3();
        public override void Preset4_Toggle3_Stopped() => TurnOffContre3();

        public override void Preset4_Toggle4_Started() => TurnOnContre4();
        public override void Preset4_Toggle4_Stopped() => TurnOffContre4();

        public override void Preset4_Toggle5_Started() => TurnOnLedJardinCour();
        public override void Preset4_Toggle5_Stopped() => TurnOffLedJardinCour();

        public override void Preset4_Toggle6_Started() => TurnOnServoFace();
        public override void Preset4_Toggle6_Stopped() => TurnOffServoFace();

        public override void Preset4_Toggle7_Started() => TurnOnServoCenter();
        public override void Preset4_Toggle7_Stopped() => TurnOffServoCenter();

        public override void Preset4_Toggle8_Started() => TurnOnLedCourJardin();
        public override void Preset4_Toggle8_Stopped() => TurnOffLedCourJardin();
        #endregion

        #region Knobs
        public override void Preset4_Knob1_Changed(byte value) => SetFade(value);
        public override void Preset4_Knob2_Changed(byte value) => SetLedDimmer(value);
        public override void Preset4_Knob3_Changed(byte value) => SetFacesDimmer(value);
        public override void Preset4_Knob4_Changed(byte value) => SetContresDimmer(value);
        public override void Preset4_Knob5_Changed(byte value) => SetServoFacePan(value);
        public override void Preset4_Knob6_Changed(byte value) => SetServoFaceTilt(value);
        public override void Preset4_Knob7_Changed(byte value) => SetServoCenterPan(value);
        public override void Preset4_Knob8_Changed(byte value) => SetServoCenterTilt(value);
        #endregion

        #region Programs
        public override void Preset4_Program1_Started() { }
        public override void Preset4_Program2_Started() { }
        public override void Preset4_Program3_Started() { }
        public override void Preset4_Program4_Started() { }
        public override void Preset4_Program5_Started() { }
        public override void Preset4_Program6_Started() { }
        public override void Preset4_Program7_Started() { }
        public override void Preset4_Program8_Started() { }
        #endregion
        #endregion

        #region Functions      
        private void SetFade(byte midi) => lights.fade = MidiToDmx(midi);
        private void SetLedDimmer(byte midi) => lights.dimmerLEDs = MidiToDmx(midi);
        private void SetFacesDimmer(byte midi) => lights.dimmerFaces = MidiToDmx(midi);
        private void SetContresDimmer(byte midi) => lights.dimmerContres = MidiToDmx(midi);

        private void SetServoCenterPan(byte midi) => lights.servoCenterPan = MidiToDmx(midi);
        private void SetServoCenterTilt(byte midi) => lights.servoCenterTilt = MidiToDmx(midi);

        private void SetServoFacePan(byte midi) => lights.servoFacePan = MidiToDmx(midi);
        private void SetServoFaceTilt(byte midi) => lights.servoFaceTilt = MidiToDmx(midi);

        private void TurnOnContre1() => lights.dimmerContre1 = 0xff;
        private void TurnOffContre1() => lights.dimmerContre1 = 0x00;
        private void TurnOnContre2() => lights.dimmerContre2 = 0xff;
        private void TurnOffContre2() => lights.dimmerContre2 = 0x00;
        private void TurnOnContre3() => lights.dimmerContre3 = 0xff;
        private void TurnOffContre3() => lights.dimmerContre3 = 0x00;
        private void TurnOnContre4() => lights.dimmerContre4 = 0xff;
        private void TurnOffContre4() => lights.dimmerContre4 = 0x00;

        private void TurnOnLedJardinCour() => lights.dimmerJardinCour = 0xff;
        private void TurnOffLedJardinCour() => lights.dimmerJardinCour = 0x00;

        private void TurnOnLedCourJardin() => lights.dimmerCourJardin = 0xff;
        private void TurnOffLedCourJardin() => lights.dimmerCourJardin = 0x00;

        private void TurnOnServoCenter()
        {
            lights.servoCenterDimmer = 0xff;
            lights.servoCenterWhite = 0xff;
        }

        private void TurnOffServoCenter()
        {
            lights.servoCenterDimmer = 0x00;
            lights.servoCenterWhite = 0x00;
        }

        private void TurnOnServoFace()
        {
            lights.servoFaceDimmer = 0xff;
            lights.servoFaceWhite = 0xff;
        }

        private void TurnOffServoFace()
        {
            lights.servoFaceDimmer = 0x00;
            lights.servoFaceWhite = 0x00;
        }
        #endregion

        private static byte MidiToDmx(byte midi) => (byte)(2 * midi);
    }
}