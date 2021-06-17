using Improvibar.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Improvibar.Shows
{
    public abstract class ImprovibarShow : MonoBehaviour
    {
        private void Awake()
        {
            AkaiLPD8Dispatcher akai = FindObjectOfType<AkaiLPD8Dispatcher>();


            #region Preset1
            akai.preset1.toggle1.onStarted.AddListener(Preset1_Toggle1_Started);
            akai.preset1.toggle1.onStopped.AddListener(Preset1_Toggle1_Stopped);

            akai.preset1.toggle2.onStarted.AddListener(Preset1_Toggle2_Started);
            akai.preset1.toggle2.onStopped.AddListener(Preset1_Toggle2_Stopped);

            akai.preset1.toggle3.onStarted.AddListener(Preset1_Toggle3_Started);
            akai.preset1.toggle3.onStopped.AddListener(Preset1_Toggle3_Stopped);

            akai.preset1.toggle4.onStarted.AddListener(Preset1_Toggle4_Started);
            akai.preset1.toggle4.onStopped.AddListener(Preset1_Toggle4_Stopped);

            akai.preset1.toggle5.onStarted.AddListener(Preset1_Toggle5_Started);
            akai.preset1.toggle5.onStopped.AddListener(Preset1_Toggle5_Stopped);

            akai.preset1.toggle6.onStarted.AddListener(Preset1_Toggle6_Started);
            akai.preset1.toggle6.onStopped.AddListener(Preset1_Toggle6_Stopped);

            akai.preset1.toggle7.onStarted.AddListener(Preset1_Toggle7_Started);
            akai.preset1.toggle7.onStopped.AddListener(Preset1_Toggle7_Stopped);

            akai.preset1.toggle8.onStarted.AddListener(Preset1_Toggle8_Started);
            akai.preset1.toggle8.onStopped.AddListener(Preset1_Toggle8_Stopped);


            akai.preset1.knob1.onValueChanged.AddListener(Preset1_Knob1_Changed);
            akai.preset1.knob2.onValueChanged.AddListener(Preset1_Knob2_Changed);
            akai.preset1.knob3.onValueChanged.AddListener(Preset1_Knob3_Changed);
            akai.preset1.knob4.onValueChanged.AddListener(Preset1_Knob4_Changed);
            akai.preset1.knob5.onValueChanged.AddListener(Preset1_Knob5_Changed);
            akai.preset1.knob6.onValueChanged.AddListener(Preset1_Knob6_Changed);
            akai.preset1.knob7.onValueChanged.AddListener(Preset1_Knob7_Changed);
            akai.preset1.knob8.onValueChanged.AddListener(Preset1_Knob8_Changed);


            akai.preset1.program1.onLaunched.AddListener(Preset1_Program1_Started);
            akai.preset1.program2.onLaunched.AddListener(Preset1_Program2_Started);
            akai.preset1.program3.onLaunched.AddListener(Preset1_Program3_Started);
            akai.preset1.program4.onLaunched.AddListener(Preset1_Program4_Started);
            akai.preset1.program5.onLaunched.AddListener(Preset1_Program5_Started);
            akai.preset1.program6.onLaunched.AddListener(Preset1_Program6_Started);
            akai.preset1.program7.onLaunched.AddListener(Preset1_Program7_Started);
            akai.preset1.program8.onLaunched.AddListener(Preset1_Program8_Started);
            #endregion


            #region Preset2
            akai.preset2.toggle1.onStarted.AddListener(Preset2_Toggle1_Started);
            akai.preset2.toggle1.onStopped.AddListener(Preset2_Toggle1_Stopped);

            akai.preset2.toggle2.onStarted.AddListener(Preset2_Toggle2_Started);
            akai.preset2.toggle2.onStopped.AddListener(Preset2_Toggle2_Stopped);

            akai.preset2.toggle3.onStarted.AddListener(Preset2_Toggle3_Started);
            akai.preset2.toggle3.onStopped.AddListener(Preset2_Toggle3_Stopped);

            akai.preset2.toggle4.onStarted.AddListener(Preset2_Toggle4_Started);
            akai.preset2.toggle4.onStopped.AddListener(Preset2_Toggle4_Stopped);

            akai.preset2.toggle5.onStarted.AddListener(Preset2_Toggle5_Started);
            akai.preset2.toggle5.onStopped.AddListener(Preset2_Toggle5_Stopped);

            akai.preset2.toggle6.onStarted.AddListener(Preset2_Toggle6_Started);
            akai.preset2.toggle6.onStopped.AddListener(Preset2_Toggle6_Stopped);

            akai.preset2.toggle7.onStarted.AddListener(Preset2_Toggle7_Started);
            akai.preset2.toggle7.onStopped.AddListener(Preset2_Toggle7_Stopped);

            akai.preset2.toggle8.onStarted.AddListener(Preset2_Toggle8_Started);
            akai.preset2.toggle8.onStopped.AddListener(Preset2_Toggle8_Stopped);


            akai.preset2.knob1.onValueChanged.AddListener(Preset2_Knob1_Changed);
            akai.preset2.knob2.onValueChanged.AddListener(Preset2_Knob2_Changed);
            akai.preset2.knob3.onValueChanged.AddListener(Preset2_Knob3_Changed);
            akai.preset2.knob4.onValueChanged.AddListener(Preset2_Knob4_Changed);
            akai.preset2.knob5.onValueChanged.AddListener(Preset2_Knob5_Changed);
            akai.preset2.knob6.onValueChanged.AddListener(Preset2_Knob6_Changed);
            akai.preset2.knob7.onValueChanged.AddListener(Preset2_Knob7_Changed);
            akai.preset2.knob8.onValueChanged.AddListener(Preset2_Knob8_Changed);


            akai.preset2.program1.onLaunched.AddListener(Preset2_Program1_Started);
            akai.preset2.program2.onLaunched.AddListener(Preset2_Program2_Started);
            akai.preset2.program3.onLaunched.AddListener(Preset2_Program3_Started);
            akai.preset2.program4.onLaunched.AddListener(Preset2_Program4_Started);
            akai.preset2.program5.onLaunched.AddListener(Preset2_Program5_Started);
            akai.preset2.program6.onLaunched.AddListener(Preset2_Program6_Started);
            akai.preset2.program7.onLaunched.AddListener(Preset2_Program7_Started);
            akai.preset2.program8.onLaunched.AddListener(Preset2_Program8_Started);
            #endregion


            #region Preset3
            akai.preset3.toggle1.onStarted.AddListener(Preset3_Toggle1_Started);
            akai.preset3.toggle1.onStopped.AddListener(Preset3_Toggle1_Stopped);

            akai.preset3.toggle2.onStarted.AddListener(Preset3_Toggle2_Started);
            akai.preset3.toggle2.onStopped.AddListener(Preset3_Toggle2_Stopped);

            akai.preset3.toggle3.onStarted.AddListener(Preset3_Toggle3_Started);
            akai.preset3.toggle3.onStopped.AddListener(Preset3_Toggle3_Stopped);

            akai.preset3.toggle4.onStarted.AddListener(Preset3_Toggle4_Started);
            akai.preset3.toggle4.onStopped.AddListener(Preset3_Toggle4_Stopped);

            akai.preset3.toggle5.onStarted.AddListener(Preset3_Toggle5_Started);
            akai.preset3.toggle5.onStopped.AddListener(Preset3_Toggle5_Stopped);

            akai.preset3.toggle6.onStarted.AddListener(Preset3_Toggle6_Started);
            akai.preset3.toggle6.onStopped.AddListener(Preset3_Toggle6_Stopped);

            akai.preset3.toggle7.onStarted.AddListener(Preset3_Toggle7_Started);
            akai.preset3.toggle7.onStopped.AddListener(Preset3_Toggle7_Stopped);

            akai.preset3.toggle8.onStarted.AddListener(Preset3_Toggle8_Started);
            akai.preset3.toggle8.onStopped.AddListener(Preset3_Toggle8_Stopped);


            akai.preset3.knob1.onValueChanged.AddListener(Preset3_Knob1_Changed);
            akai.preset3.knob2.onValueChanged.AddListener(Preset3_Knob2_Changed);
            akai.preset3.knob3.onValueChanged.AddListener(Preset3_Knob3_Changed);
            akai.preset3.knob4.onValueChanged.AddListener(Preset3_Knob4_Changed);
            akai.preset3.knob5.onValueChanged.AddListener(Preset3_Knob5_Changed);
            akai.preset3.knob6.onValueChanged.AddListener(Preset3_Knob6_Changed);
            akai.preset3.knob7.onValueChanged.AddListener(Preset3_Knob7_Changed);
            akai.preset3.knob8.onValueChanged.AddListener(Preset3_Knob8_Changed);


            akai.preset3.program1.onLaunched.AddListener(Preset3_Program1_Started);
            akai.preset3.program2.onLaunched.AddListener(Preset3_Program2_Started);
            akai.preset3.program3.onLaunched.AddListener(Preset3_Program3_Started);
            akai.preset3.program4.onLaunched.AddListener(Preset3_Program4_Started);
            akai.preset3.program5.onLaunched.AddListener(Preset3_Program5_Started);
            akai.preset3.program6.onLaunched.AddListener(Preset3_Program6_Started);
            akai.preset3.program7.onLaunched.AddListener(Preset3_Program7_Started);
            akai.preset3.program8.onLaunched.AddListener(Preset3_Program8_Started);
            #endregion


            #region Preset1
            akai.preset4.toggle1.onStarted.AddListener(Preset4_Toggle1_Started);
            akai.preset4.toggle1.onStopped.AddListener(Preset4_Toggle1_Stopped);

            akai.preset4.toggle2.onStarted.AddListener(Preset4_Toggle2_Started);
            akai.preset4.toggle2.onStopped.AddListener(Preset4_Toggle2_Stopped);

            akai.preset4.toggle3.onStarted.AddListener(Preset4_Toggle3_Started);
            akai.preset4.toggle3.onStopped.AddListener(Preset4_Toggle3_Stopped);

            akai.preset4.toggle4.onStarted.AddListener(Preset4_Toggle4_Started);
            akai.preset4.toggle4.onStopped.AddListener(Preset4_Toggle4_Stopped);

            akai.preset4.toggle5.onStarted.AddListener(Preset4_Toggle5_Started);
            akai.preset4.toggle5.onStopped.AddListener(Preset4_Toggle5_Stopped);

            akai.preset4.toggle6.onStarted.AddListener(Preset4_Toggle6_Started);
            akai.preset4.toggle6.onStopped.AddListener(Preset4_Toggle6_Stopped);

            akai.preset4.toggle7.onStarted.AddListener(Preset4_Toggle7_Started);
            akai.preset4.toggle7.onStopped.AddListener(Preset4_Toggle7_Stopped);

            akai.preset4.toggle8.onStarted.AddListener(Preset4_Toggle8_Started);
            akai.preset4.toggle8.onStopped.AddListener(Preset4_Toggle8_Stopped);


            akai.preset4.knob1.onValueChanged.AddListener(Preset4_Knob1_Changed);
            akai.preset4.knob2.onValueChanged.AddListener(Preset4_Knob2_Changed);
            akai.preset4.knob3.onValueChanged.AddListener(Preset4_Knob3_Changed);
            akai.preset4.knob4.onValueChanged.AddListener(Preset4_Knob4_Changed);
            akai.preset4.knob5.onValueChanged.AddListener(Preset4_Knob5_Changed);
            akai.preset4.knob6.onValueChanged.AddListener(Preset4_Knob6_Changed);
            akai.preset4.knob7.onValueChanged.AddListener(Preset4_Knob7_Changed);
            akai.preset4.knob8.onValueChanged.AddListener(Preset4_Knob8_Changed);


            akai.preset4.program1.onLaunched.AddListener(Preset4_Program1_Started);
            akai.preset4.program2.onLaunched.AddListener(Preset4_Program2_Started);
            akai.preset4.program3.onLaunched.AddListener(Preset4_Program3_Started);
            akai.preset4.program4.onLaunched.AddListener(Preset4_Program4_Started);
            akai.preset4.program5.onLaunched.AddListener(Preset4_Program5_Started);
            akai.preset4.program6.onLaunched.AddListener(Preset4_Program6_Started);
            akai.preset4.program7.onLaunched.AddListener(Preset4_Program7_Started);
            akai.preset4.program8.onLaunched.AddListener(Preset4_Program8_Started);
            #endregion
        }

        #region Preset1
        #region Toggles
        public virtual void Preset1_Toggle1_Started() { }
        public virtual void Preset1_Toggle1_Stopped() { }
        public virtual void Preset1_Toggle2_Started() { }
        public virtual void Preset1_Toggle2_Stopped() { }
        public virtual void Preset1_Toggle3_Started() { }
        public virtual void Preset1_Toggle3_Stopped() { }
        public virtual void Preset1_Toggle4_Started() { }
        public virtual void Preset1_Toggle4_Stopped() { }
        public virtual void Preset1_Toggle5_Started() { }
        public virtual void Preset1_Toggle5_Stopped() { }
        public virtual void Preset1_Toggle6_Started() { }
        public virtual void Preset1_Toggle6_Stopped() { }
        public virtual void Preset1_Toggle7_Started() { }
        public virtual void Preset1_Toggle7_Stopped() { }
        public virtual void Preset1_Toggle8_Started() { }
        public virtual void Preset1_Toggle8_Stopped() { }
        #endregion


        #region Knobs
        public virtual void Preset1_Knob1_Changed(byte value) { }
        public virtual void Preset1_Knob2_Changed(byte value) { }
        public virtual void Preset1_Knob3_Changed(byte value) { }
        public virtual void Preset1_Knob4_Changed(byte value) { }
        public virtual void Preset1_Knob5_Changed(byte value) { }
        public virtual void Preset1_Knob6_Changed(byte value) { }
        public virtual void Preset1_Knob7_Changed(byte value) { }
        public virtual void Preset1_Knob8_Changed(byte value) { }
        #endregion


        #region Programs
        public virtual void Preset1_Program1_Started() { }
        public virtual void Preset1_Program2_Started() { }
        public virtual void Preset1_Program3_Started() { }
        public virtual void Preset1_Program4_Started() { }
        public virtual void Preset1_Program5_Started() { }
        public virtual void Preset1_Program6_Started() { }
        public virtual void Preset1_Program7_Started() { }
        public virtual void Preset1_Program8_Started() { }
        #endregion 
        #endregion

        #region Preset2
        #region Toggles
        public virtual void Preset2_Toggle1_Started() { }
        public virtual void Preset2_Toggle1_Stopped() { }
        public virtual void Preset2_Toggle2_Started() { }
        public virtual void Preset2_Toggle2_Stopped() { }
        public virtual void Preset2_Toggle3_Started() { }
        public virtual void Preset2_Toggle3_Stopped() { }
        public virtual void Preset2_Toggle4_Started() { }
        public virtual void Preset2_Toggle4_Stopped() { }
        public virtual void Preset2_Toggle5_Started() { }
        public virtual void Preset2_Toggle5_Stopped() { }
        public virtual void Preset2_Toggle6_Started() { }
        public virtual void Preset2_Toggle6_Stopped() { }
        public virtual void Preset2_Toggle7_Started() { }
        public virtual void Preset2_Toggle7_Stopped() { }
        public virtual void Preset2_Toggle8_Started() { }
        public virtual void Preset2_Toggle8_Stopped() { }
        #endregion


        #region Knobs
        public virtual void Preset2_Knob1_Changed(byte value) { }
        public virtual void Preset2_Knob2_Changed(byte value) { }
        public virtual void Preset2_Knob3_Changed(byte value) { }
        public virtual void Preset2_Knob4_Changed(byte value) { }
        public virtual void Preset2_Knob5_Changed(byte value) { }
        public virtual void Preset2_Knob6_Changed(byte value) { }
        public virtual void Preset2_Knob7_Changed(byte value) { }
        public virtual void Preset2_Knob8_Changed(byte value) { }
        #endregion


        #region Programs
        public virtual void Preset2_Program1_Started() { }
        public virtual void Preset2_Program2_Started() { }
        public virtual void Preset2_Program3_Started() { }
        public virtual void Preset2_Program4_Started() { }
        public virtual void Preset2_Program5_Started() { }
        public virtual void Preset2_Program6_Started() { }
        public virtual void Preset2_Program7_Started() { }
        public virtual void Preset2_Program8_Started() { }
        #endregion 
        #endregion

        #region Preset3
        #region Toggles
        public virtual void Preset3_Toggle1_Started() { }
        public virtual void Preset3_Toggle1_Stopped() { }
        public virtual void Preset3_Toggle2_Started() { }
        public virtual void Preset3_Toggle2_Stopped() { }
        public virtual void Preset3_Toggle3_Started() { }
        public virtual void Preset3_Toggle3_Stopped() { }
        public virtual void Preset3_Toggle4_Started() { }
        public virtual void Preset3_Toggle4_Stopped() { }
        public virtual void Preset3_Toggle5_Started() { }
        public virtual void Preset3_Toggle5_Stopped() { }
        public virtual void Preset3_Toggle6_Started() { }
        public virtual void Preset3_Toggle6_Stopped() { }
        public virtual void Preset3_Toggle7_Started() { }
        public virtual void Preset3_Toggle7_Stopped() { }
        public virtual void Preset3_Toggle8_Started() { }
        public virtual void Preset3_Toggle8_Stopped() { }
        #endregion


        #region Knobs
        public virtual void Preset3_Knob1_Changed(byte value) { }
        public virtual void Preset3_Knob2_Changed(byte value) { }
        public virtual void Preset3_Knob3_Changed(byte value) { }
        public virtual void Preset3_Knob4_Changed(byte value) { }
        public virtual void Preset3_Knob5_Changed(byte value) { }
        public virtual void Preset3_Knob6_Changed(byte value) { }
        public virtual void Preset3_Knob7_Changed(byte value) { }
        public virtual void Preset3_Knob8_Changed(byte value) { }
        #endregion


        #region Programs
        public virtual void Preset3_Program1_Started() { }
        public virtual void Preset3_Program2_Started() { }
        public virtual void Preset3_Program3_Started() { }
        public virtual void Preset3_Program4_Started() { }
        public virtual void Preset3_Program5_Started() { }
        public virtual void Preset3_Program6_Started() { }
        public virtual void Preset3_Program7_Started() { }
        public virtual void Preset3_Program8_Started() { }
        #endregion 
        #endregion

        #region Preset4
        #region Toggles
        public virtual void Preset4_Toggle1_Started() { }
        public virtual void Preset4_Toggle1_Stopped() { }
        public virtual void Preset4_Toggle2_Started() { }
        public virtual void Preset4_Toggle2_Stopped() { }
        public virtual void Preset4_Toggle3_Started() { }
        public virtual void Preset4_Toggle3_Stopped() { }
        public virtual void Preset4_Toggle4_Started() { }
        public virtual void Preset4_Toggle4_Stopped() { }
        public virtual void Preset4_Toggle5_Started() { }
        public virtual void Preset4_Toggle5_Stopped() { }
        public virtual void Preset4_Toggle6_Started() { }
        public virtual void Preset4_Toggle6_Stopped() { }
        public virtual void Preset4_Toggle7_Started() { }
        public virtual void Preset4_Toggle7_Stopped() { }
        public virtual void Preset4_Toggle8_Started() { }
        public virtual void Preset4_Toggle8_Stopped() { }
        #endregion


        #region Knobs
        public virtual void Preset4_Knob1_Changed(byte value) { }
        public virtual void Preset4_Knob2_Changed(byte value) { }
        public virtual void Preset4_Knob3_Changed(byte value) { }
        public virtual void Preset4_Knob4_Changed(byte value) { }
        public virtual void Preset4_Knob5_Changed(byte value) { }
        public virtual void Preset4_Knob6_Changed(byte value) { }
        public virtual void Preset4_Knob7_Changed(byte value) { }
        public virtual void Preset4_Knob8_Changed(byte value) { }
        #endregion


        #region Programs
        public virtual void Preset4_Program1_Started() { }
        public virtual void Preset4_Program2_Started() { }
        public virtual void Preset4_Program3_Started() { }
        public virtual void Preset4_Program4_Started() { }
        public virtual void Preset4_Program5_Started() { }
        public virtual void Preset4_Program6_Started() { }
        public virtual void Preset4_Program7_Started() { }
        public virtual void Preset4_Program8_Started() { }
        #endregion 
        #endregion
    }
}