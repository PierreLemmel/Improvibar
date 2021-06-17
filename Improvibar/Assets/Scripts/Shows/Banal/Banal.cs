using Improvibar.Dmx.Fixtures;
using Improvibar.Shows;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Improvibar.Banal
{
    public class Banal : ImprovibarShow
    {
        public TestFixture testPierre;

        #region Preset1
        #region Toggles
        public override void Preset1_Toggle1_Started()
        {
            Debug.Log(nameof(Preset1_Toggle1_Started));
        }

        public override void Preset1_Toggle1_Stopped()
        {
            Debug.Log(nameof(Preset1_Toggle1_Stopped));
        }

        public override void Preset1_Toggle2_Started()
        {
            Debug.Log(nameof(Preset1_Toggle2_Started));
        }

        public override void Preset1_Toggle2_Stopped()
        {
            Debug.Log(nameof(Preset1_Toggle2_Stopped));
        }

        public override void Preset1_Toggle3_Started()
        {
            Debug.Log(nameof(Preset1_Toggle3_Started));
        }

        public override void Preset1_Toggle3_Stopped()
        {
            Debug.Log(nameof(Preset1_Toggle3_Stopped));
        }

        public override void Preset1_Toggle4_Started()
        {
            Debug.Log(nameof(Preset1_Toggle4_Started));
        }

        public override void Preset1_Toggle4_Stopped()
        {
            Debug.Log(nameof(Preset1_Toggle4_Stopped));
        }

        public override void Preset1_Toggle5_Started()
        {
            Debug.Log(nameof(Preset1_Toggle5_Started));
        }

        public override void Preset1_Toggle5_Stopped()
        {
            Debug.Log(nameof(Preset1_Toggle5_Stopped));
        }

        public override void Preset1_Toggle6_Started()
        {
            Debug.Log(nameof(Preset1_Toggle6_Started));
        }

        public override void Preset1_Toggle6_Stopped()
        {
            Debug.Log(nameof(Preset1_Toggle6_Stopped));
        }

        public override void Preset1_Toggle7_Started()
        {
            Debug.Log(nameof(Preset1_Toggle7_Started));
        }

        public override void Preset1_Toggle7_Stopped()
        {
            Debug.Log(nameof(Preset1_Toggle7_Stopped));
        }

        public override void Preset1_Toggle8_Started()
        {
            Debug.Log(nameof(Preset1_Toggle8_Started));
        }

        public override void Preset1_Toggle8_Stopped()
        {
            Debug.Log(nameof(Preset1_Toggle8_Stopped));
        }
        #endregion


        #region Knobs
        public override void Preset1_Knob1_Changed(byte value)
        {
            testPierre.testChannels[0] = 2 * value;
            testPierre.testChannels[2] = 2 * value;
        }

        public override void Preset1_Knob2_Changed(byte value)
        {
            Debug.Log(nameof(Preset1_Knob2_Changed));
        }

        public override void Preset1_Knob3_Changed(byte value)
        {
            Debug.Log(nameof(Preset1_Knob3_Changed));
        }

        public override void Preset1_Knob4_Changed(byte value)
        {
            Debug.Log(nameof(Preset1_Knob4_Changed));
        }

        public override void Preset1_Knob5_Changed(byte value)
        {
            Debug.Log(nameof(Preset1_Knob5_Changed));
        }

        public override void Preset1_Knob6_Changed(byte value)
        {
            Debug.Log(nameof(Preset1_Knob6_Changed));
        }

        public override void Preset1_Knob7_Changed(byte value)
        {
            Debug.Log(nameof(Preset1_Knob7_Changed));
        }

        public override void Preset1_Knob8_Changed(byte value)
        {
            Debug.Log(nameof(Preset1_Knob8_Changed));
        }
        #endregion


        #region Programs
        public override void Preset1_Program1_Started()
        {
            Debug.Log(nameof(Preset1_Program1_Started));
        }

        public override void Preset1_Program2_Started()
        {
            Debug.Log(nameof(Preset1_Program2_Started));
        }

        public override void Preset1_Program3_Started()
        {
            Debug.Log(nameof(Preset1_Program3_Started));
        }

        public override void Preset1_Program4_Started()
        {
            Debug.Log(nameof(Preset1_Program4_Started));
        }

        public override void Preset1_Program5_Started()
        {
            Debug.Log(nameof(Preset1_Program5_Started));
        }

        public override void Preset1_Program6_Started()
        {
            Debug.Log(nameof(Preset1_Program6_Started));
        }

        public override void Preset1_Program7_Started()
        {
            Debug.Log(nameof(Preset1_Program7_Started));
        }

        public override void Preset1_Program8_Started()
        {
            Debug.Log(nameof(Preset1_Program8_Started));
        }
        #endregion 
        #endregion

        #region Preset2
        #region Toggles
        public override void Preset2_Toggle1_Started()
        {
            Debug.Log(nameof(Preset2_Toggle1_Started));
        }

        public override void Preset2_Toggle1_Stopped()
        {
            Debug.Log(nameof(Preset2_Toggle1_Stopped));
        }

        public override void Preset2_Toggle2_Started()
        {
            Debug.Log(nameof(Preset2_Toggle2_Started));
        }

        public override void Preset2_Toggle2_Stopped()
        {
            Debug.Log(nameof(Preset2_Toggle2_Stopped));
        }

        public override void Preset2_Toggle3_Started()
        {
            Debug.Log(nameof(Preset2_Toggle3_Started));
        }

        public override void Preset2_Toggle3_Stopped()
        {
            Debug.Log(nameof(Preset2_Toggle3_Stopped));
        }

        public override void Preset2_Toggle4_Started()
        {
            Debug.Log(nameof(Preset2_Toggle4_Started));
        }

        public override void Preset2_Toggle4_Stopped()
        {
            Debug.Log(nameof(Preset2_Toggle4_Stopped));
        }

        public override void Preset2_Toggle5_Started()
        {
            Debug.Log(nameof(Preset2_Toggle5_Started));
        }

        public override void Preset2_Toggle5_Stopped()
        {
            Debug.Log(nameof(Preset2_Toggle5_Stopped));
        }

        public override void Preset2_Toggle6_Started()
        {
            Debug.Log(nameof(Preset2_Toggle6_Started));
        }

        public override void Preset2_Toggle6_Stopped()
        {
            Debug.Log(nameof(Preset2_Toggle6_Stopped));
        }

        public override void Preset2_Toggle7_Started()
        {
            Debug.Log(nameof(Preset2_Toggle7_Started));
        }

        public override void Preset2_Toggle7_Stopped()
        {
            Debug.Log(nameof(Preset2_Toggle7_Stopped));
        }

        public override void Preset2_Toggle8_Started()
        {
            Debug.Log(nameof(Preset2_Toggle8_Started));
        }

        public override void Preset2_Toggle8_Stopped()
        {
            Debug.Log(nameof(Preset2_Toggle8_Stopped));
        }
        #endregion


        #region Knobs
        public override void Preset2_Knob1_Changed(byte value)
        {
            Debug.Log(nameof(Preset2_Knob1_Changed));
        }

        public override void Preset2_Knob2_Changed(byte value)
        {
            Debug.Log(nameof(Preset2_Knob2_Changed));
        }

        public override void Preset2_Knob3_Changed(byte value)
        {
            Debug.Log(nameof(Preset2_Knob3_Changed));
        }

        public override void Preset2_Knob4_Changed(byte value)
        {
            Debug.Log(nameof(Preset2_Knob4_Changed));
        }

        public override void Preset2_Knob5_Changed(byte value)
        {
            Debug.Log(nameof(Preset2_Knob5_Changed));
        }

        public override void Preset2_Knob6_Changed(byte value)
        {
            Debug.Log(nameof(Preset2_Knob6_Changed));
        }

        public override void Preset2_Knob7_Changed(byte value)
        {
            Debug.Log(nameof(Preset2_Knob7_Changed));
        }

        public override void Preset2_Knob8_Changed(byte value)
        {
            Debug.Log(nameof(Preset2_Knob8_Changed));
        }

        #endregion


        #region Programs
        public override void Preset2_Program1_Started()
        {
            Debug.Log(nameof(Preset2_Program1_Started));
        }

        public override void Preset2_Program2_Started()
        {
            Debug.Log(nameof(Preset2_Program2_Started));
        }

        public override void Preset2_Program3_Started()
        {
            Debug.Log(nameof(Preset2_Program3_Started));
        }

        public override void Preset2_Program4_Started()
        {
            Debug.Log(nameof(Preset2_Program4_Started));
        }

        public override void Preset2_Program5_Started()
        {
            Debug.Log(nameof(Preset2_Program5_Started));
        }

        public override void Preset2_Program6_Started()
        {
            Debug.Log(nameof(Preset2_Program6_Started));
        }

        public override void Preset2_Program7_Started()
        {
            Debug.Log(nameof(Preset2_Program7_Started));
        }

        public override void Preset2_Program8_Started()
        {
            Debug.Log(nameof(Preset2_Program8_Started));
        }
        #endregion 
        #endregion

        #region Preset3
        #region Toggles
        public override void Preset3_Toggle1_Started()
        {
            Debug.Log(nameof(Preset3_Toggle1_Started));
        }

        public override void Preset3_Toggle1_Stopped()
        {
            Debug.Log(nameof(Preset3_Toggle1_Stopped));
        }

        public override void Preset3_Toggle2_Started()
        {
            Debug.Log(nameof(Preset3_Toggle2_Started));
        }

        public override void Preset3_Toggle2_Stopped()
        {
            Debug.Log(nameof(Preset3_Toggle2_Stopped));
        }

        public override void Preset3_Toggle3_Started()
        {
            Debug.Log(nameof(Preset3_Toggle3_Started));
        }

        public override void Preset3_Toggle3_Stopped()
        {
            Debug.Log(nameof(Preset3_Toggle3_Stopped));
        }

        public override void Preset3_Toggle4_Started()
        {
            Debug.Log(nameof(Preset3_Toggle4_Started));
        }

        public override void Preset3_Toggle4_Stopped()
        {
            Debug.Log(nameof(Preset3_Toggle4_Stopped));
        }

        public override void Preset3_Toggle5_Started()
        {
            Debug.Log(nameof(Preset3_Toggle5_Started));
        }

        public override void Preset3_Toggle5_Stopped()
        {
            Debug.Log(nameof(Preset3_Toggle5_Stopped));
        }

        public override void Preset3_Toggle6_Started()
        {
            Debug.Log(nameof(Preset3_Toggle6_Started));
        }

        public override void Preset3_Toggle6_Stopped()
        {
            Debug.Log(nameof(Preset3_Toggle6_Stopped));
        }

        public override void Preset3_Toggle7_Started()
        {
            Debug.Log(nameof(Preset3_Toggle7_Started));
        }

        public override void Preset3_Toggle7_Stopped()
        {
            Debug.Log(nameof(Preset3_Toggle7_Stopped));
        }

        public override void Preset3_Toggle8_Started()
        {
            Debug.Log(nameof(Preset3_Toggle8_Started));
        }

        public override void Preset3_Toggle8_Stopped()
        {
            Debug.Log(nameof(Preset3_Toggle8_Stopped));
        }
        #endregion


        #region Knobs
        public override void Preset3_Knob1_Changed(byte value)
        {
            Debug.Log(nameof(Preset3_Knob1_Changed));
        }

        public override void Preset3_Knob2_Changed(byte value)
        {
            Debug.Log(nameof(Preset3_Knob2_Changed));
        }

        public override void Preset3_Knob3_Changed(byte value)
        {
            Debug.Log(nameof(Preset3_Knob3_Changed));
        }

        public override void Preset3_Knob4_Changed(byte value)
        {
            Debug.Log(nameof(Preset3_Knob4_Changed));
        }

        public override void Preset3_Knob5_Changed(byte value)
        {
            Debug.Log(nameof(Preset3_Knob5_Changed));
        }

        public override void Preset3_Knob6_Changed(byte value)
        {
            Debug.Log(nameof(Preset3_Knob6_Changed));
        }

        public override void Preset3_Knob7_Changed(byte value)
        {
            Debug.Log(nameof(Preset3_Knob7_Changed));
        }

        public override void Preset3_Knob8_Changed(byte value)
        {
            Debug.Log(nameof(Preset3_Knob8_Changed));
        }
        #endregion


        #region Programs
        public override void Preset3_Program1_Started()
        {
            Debug.Log(nameof(Preset3_Program1_Started));
        }

        public override void Preset3_Program2_Started()
        {
            Debug.Log(nameof(Preset3_Program2_Started));
        }

        public override void Preset3_Program3_Started()
        {
            Debug.Log(nameof(Preset3_Program3_Started));
        }

        public override void Preset3_Program4_Started()
        {
            Debug.Log(nameof(Preset3_Program4_Started));
        }

        public override void Preset3_Program5_Started()
        {
            Debug.Log(nameof(Preset3_Program5_Started));
        }

        public override void Preset3_Program6_Started()
        {
            Debug.Log(nameof(Preset3_Program6_Started));
        }

        public override void Preset3_Program7_Started()
        {
            Debug.Log(nameof(Preset3_Program7_Started));
        }

        public override void Preset3_Program8_Started()
        {
            Debug.Log(nameof(Preset3_Program8_Started));
        }
        #endregion 
        #endregion

        #region Preset4
        #region Toggles
        public override void Preset4_Toggle1_Started()
        {
            Debug.Log(nameof(Preset4_Toggle1_Started));
        }

        public override void Preset4_Toggle1_Stopped()
        {
            Debug.Log(nameof(Preset4_Toggle1_Stopped));
        }

        public override void Preset4_Toggle2_Started()
        {
            Debug.Log(nameof(Preset4_Toggle2_Started));
        }

        public override void Preset4_Toggle2_Stopped()
        {
            Debug.Log(nameof(Preset4_Toggle2_Stopped));
        }

        public override void Preset4_Toggle3_Started()
        {
            Debug.Log(nameof(Preset4_Toggle3_Started));
        }

        public override void Preset4_Toggle3_Stopped()
        {
            Debug.Log(nameof(Preset4_Toggle3_Stopped));
        }

        public override void Preset4_Toggle4_Started()
        {
            Debug.Log(nameof(Preset4_Toggle4_Started));
        }

        public override void Preset4_Toggle4_Stopped()
        {
            Debug.Log(nameof(Preset4_Toggle4_Stopped));
        }

        public override void Preset4_Toggle5_Started()
        {
            Debug.Log(nameof(Preset4_Toggle5_Started));
        }

        public override void Preset4_Toggle5_Stopped()
        {
            Debug.Log(nameof(Preset4_Toggle5_Stopped));
        }

        public override void Preset4_Toggle6_Started()
        {
            Debug.Log(nameof(Preset4_Toggle6_Started));
        }

        public override void Preset4_Toggle6_Stopped()
        {
            Debug.Log(nameof(Preset4_Toggle6_Stopped));
        }

        public override void Preset4_Toggle7_Started()
        {
            Debug.Log(nameof(Preset4_Toggle7_Started));
        }

        public override void Preset4_Toggle7_Stopped()
        {
            Debug.Log(nameof(Preset4_Toggle7_Stopped));
        }

        public override void Preset4_Toggle8_Started()
        {
            Debug.Log(nameof(Preset4_Toggle8_Started));
        }

        public override void Preset4_Toggle8_Stopped()
        {
            Debug.Log(nameof(Preset4_Toggle8_Stopped));
        }
        #endregion


        #region Knobs
        public override void Preset4_Knob1_Changed(byte value)
        {
            Debug.Log(nameof(Preset4_Knob1_Changed));
        }

        public override void Preset4_Knob2_Changed(byte value)
        {
            Debug.Log(nameof(Preset4_Knob2_Changed));
        }

        public override void Preset4_Knob3_Changed(byte value)
        {
            Debug.Log(nameof(Preset4_Knob3_Changed));
        }

        public override void Preset4_Knob4_Changed(byte value)
        {
            Debug.Log(nameof(Preset4_Knob4_Changed));
        }

        public override void Preset4_Knob5_Changed(byte value)
        {
            Debug.Log(nameof(Preset4_Knob5_Changed));
        }

        public override void Preset4_Knob6_Changed(byte value)
        {
            Debug.Log(nameof(Preset4_Knob6_Changed));
        }

        public override void Preset4_Knob7_Changed(byte value)
        {
            Debug.Log(nameof(Preset4_Knob7_Changed));
        }

        public override void Preset4_Knob8_Changed(byte value)
        {
            Debug.Log(nameof(Preset4_Knob8_Changed));
        }
        #endregion


        #region Programs
        public override void Preset4_Program1_Started()
        {
            Debug.Log(nameof(Preset4_Program1_Started));
        }

        public override void Preset4_Program2_Started()
        {
            Debug.Log(nameof(Preset4_Program2_Started));
        }

        public override void Preset4_Program3_Started()
        {
            Debug.Log(nameof(Preset4_Program3_Started));
        }

        public override void Preset4_Program4_Started()
        {
            Debug.Log(nameof(Preset4_Program4_Started));
        }

        public override void Preset4_Program5_Started()
        {
            Debug.Log(nameof(Preset4_Program5_Started));
        }

        public override void Preset4_Program6_Started()
        {
            Debug.Log(nameof(Preset4_Program6_Started));
        }

        public override void Preset4_Program7_Started()
        {
            Debug.Log(nameof(Preset4_Program7_Started));
        }

        public override void Preset4_Program8_Started()
        {
            Debug.Log(nameof(Preset4_Program8_Started));
        }
        #endregion 
        #endregion
    }
}