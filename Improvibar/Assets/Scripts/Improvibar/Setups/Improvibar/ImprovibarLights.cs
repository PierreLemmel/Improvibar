using Improvibar.Dmx;
using Improvibar.Dmx.Fixtures;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Improvibar
{
    public class ImprovibarLights : MonoBehaviour
    {
        #region Fixtures
        [HideInPlayMode]
        [SerializeField]
        private FlatParLed_CW_WW_Amber flatParJardinCour;

        [HideInPlayMode]
        [SerializeField]
        private FlatParLed_CW_WW_Amber flatParCourJardin;

        [HideInPlayMode]
        [SerializeField]
        private ParLedRGBW parLedJardinCour;

        [HideInPlayMode]
        [SerializeField]
        private ParLedRGBW parLedCourJardin;

        [HideInPlayMode]
        [SerializeField]
        private ParLedRGBW parLedContre1;

        [HideInPlayMode]
        [SerializeField]
        private ParLedRGBW parLedContre2;

        [HideInPlayMode]
        [SerializeField]
        private ParLedRGBW parLedContre3;

        [HideInPlayMode]
        [SerializeField]
        private ParLedRGBW parLedContre4;

        [HideInPlayMode]
        [SerializeField]
        private ParLedServo_SharkCombi servoCenter;

        [HideInPlayMode]
        [SerializeField]
        private ServoDecoupeRGBW servoFace;

        private DmxControler dmxControler;
        #endregion

        #region DmxControler
        public bool blackOut = false;
        public float fade = 0.0f;

        [Range(0.0f, 1.0f)]
        public float master = 1.0f;
        #endregion

        #region Flat Faces
        [Range(0x00, 0xff)]
        public int jardinCour = 0;

        [Range(0x00, 0xff)]
        public int courJardin = 0;

        [Range(0x00, 0xff)]
        public int facesAmber = 0;

        [Range(0x00, 0xff)]
        public int facesWarm = 0;

        [Range(0x00, 0xff)]
        public int facesCold = 0;
        #endregion

        #region LEDs
        [Range(0x00, 0xff)]
        public int dimmerLEDs = 0;

        public Color colorLEDs = Color.black;

        [Range(0x00, 0xff)]
        public int strobeLEDs;
        #endregion

        #region LEDs faces
        [Range(0x00, 0xff)]
        public int dimmerFaces = 0;

        [Range(0x00, 0xff)]
        public int dimmerJardinCour = 0;

        [Range(0x00, 0xff)]
        public int dimmerCourJardin = 0;

        public Color colorFaces = Color.black;
        public Color colorJardinCour = Color.black;
        public Color colorCourJardin = Color.black;

        [Range(0x00, 0xff)]
        public int strobeFaces = 0;

        [Range(0x00, 0xff)]
        public int strobeJardinCour = 0;

        [Range(0x00, 0xff)]
        public int strobeCourJardin = 0;
        #endregion

        #region Contres
        [Range(0x00, 0xff)]
        public int dimmerContres = 0;

        [Range(0x00, 0xff)]
        public int dimmerContre1;

        [Range(0x00, 0xff)]
        public int dimmerContre2;

        [Range(0x00, 0xff)]
        public int dimmerContre3;

        [Range(0x00, 0xff)]
        public int dimmerContre4;

        public Color colorContres = Color.black;
        public Color colorContre1 = Color.black;
        public Color colorContre2 = Color.black;
        public Color colorContre3 = Color.black;
        public Color colorContre4 = Color.black;

        [Range(0x00, 0xff)]
        public int strobeContres;

        [Range(0x00, 0xff)]
        public int strobeContre1;

        [Range(0x00, 0xff)]
        public int strobeContre2;

        [Range(0x00, 0xff)]
        public int strobeContre3;

        [Range(0x00, 0xff)]
        public int strobeContre4;
        #endregion

        #region Servo Face
        [Range(0x00, 0xff)]
        public int servoFacePan = 0;

        [Range(0x00, 0xff)]
        public int servoFaceTilt = 0;

        [Range(0x00, 0xff)]
        public int servoFaceDimmer = 0;

        public Color servoFaceColor = Color.black;

        [Range(0x00, 0xff)]
        public int servoFaceWhite = 0;

        [Range(0x00, 0xff)]
        public int servoFaceStrobe = 0;
        #endregion

        #region Servo Center
        [Range(0x00, 0xff)]
        public int servoCenterPan = 0;

        [Range(0x00, 0xff)]
        public int servoCenterTilt = 0;

        [Range(0x00, 0xff)]
        public int servoCenterDimmer = 0;

        public Color servoCenterColor = Color.black;

        [Range(0x00, 0xff)]
        public int servoCenterWhite = 0;

        [Range(0x00, 0xff)]
        public int servoCenterStrobe = 0;
        #endregion

        private void Awake() => dmxControler = FindObjectOfType<DmxControler>();

        private void Update()
        {
            dmxControler.blackout = blackOut;
            dmxControler.fade = fade;
            dmxControler.master = master;

            flatParJardinCour.dimmer = jardinCour;
            flatParJardinCour.cold = facesCold;
            flatParJardinCour.warm = facesWarm;
            flatParJardinCour.amber = facesAmber;

            flatParCourJardin.dimmer = courJardin;
            flatParCourJardin.cold = facesCold;
            flatParCourJardin.warm = facesWarm;
            flatParCourJardin.amber = facesAmber;

            parLedJardinCour.dimmer = Mathf.Max(dimmerLEDs, dimmerFaces, dimmerJardinCour);
            parLedJardinCour.color = Colors.MaxByChannel(colorLEDs, colorFaces, colorJardinCour);
            parLedJardinCour.stroboscope = Mathf.Max(strobeLEDs, strobeFaces, strobeJardinCour);

            parLedCourJardin.dimmer = Mathf.Max(dimmerLEDs, dimmerFaces, dimmerCourJardin);
            parLedCourJardin.color = Colors.MaxByChannel(colorLEDs, colorFaces, colorCourJardin);
            parLedCourJardin.stroboscope = Mathf.Max(strobeLEDs, strobeFaces, strobeCourJardin);

            parLedContre1.dimmer = Mathf.Max(dimmerLEDs, dimmerContres, dimmerContre1);
            parLedContre1.color = Colors.MaxByChannel(colorLEDs, colorContres, colorContre1);
            parLedContre1.stroboscope = Mathf.Max(strobeLEDs, strobeContres, strobeContre1);

            parLedContre2.dimmer = Mathf.Max(dimmerLEDs, dimmerContres, dimmerContre2);
            parLedContre2.color = Colors.MaxByChannel(colorLEDs, colorContres, colorContre2);
            parLedContre2.stroboscope = Mathf.Max(strobeLEDs, strobeContres, strobeContre2);

            parLedContre3.dimmer = Mathf.Max(dimmerLEDs, dimmerContres, dimmerContre3);
            parLedContre3.color = Colors.MaxByChannel(colorLEDs, colorContres, colorContre3);
            parLedContre3.stroboscope = Mathf.Max(strobeLEDs, strobeContres, strobeContre3);

            parLedContre4.dimmer = Mathf.Max(dimmerLEDs, dimmerContres, dimmerContre4);
            parLedContre4.color = Colors.MaxByChannel(colorLEDs, colorContres, colorContre4);
            parLedContre4.stroboscope = Mathf.Max(strobeLEDs, strobeContres, strobeContre4);

            servoCenter.pan = servoCenterPan;
            servoCenter.tilt = servoCenterTilt;
            servoCenter.dimmer = servoCenterDimmer;
            servoCenter.color = servoCenterColor;
            servoCenter.strobe = servoCenterStrobe;
            servoCenter.cold = servoCenterWhite;

            servoFace.pan = servoFacePan;
            servoFace.tilt = servoFaceTilt;
            servoFace.color = servoFaceColor;
            servoFace.strobe = servoFaceStrobe;
            servoFace.dimmer = servoFaceDimmer;
            servoFace.white =  servoFaceWhite;
        }
    }
}
