using Improvibar.Dmx;
using Improvibar.Dmx.Fixtures;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Improvibar
{
    public class PierreLights : MonoBehaviour
    {
        #region Fixtures
        [HideInPlayMode]
        [SerializeField]
        private ParLedRGBUv parLedRgbJardinCour;

        [HideInPlayMode]
        [SerializeField]
        private FlatParLed_CW_WW flatParLedJardinCour;
        
        [HideInPlayMode]
        [SerializeField]
        private FlatParLed_CW_WW flatParLedCourJardin;

        [HideInPlayMode]
        [SerializeField]
        private ParLedRGBUv parLedRgbCourJardin;

        private DmxControler dmxControler;
        #endregion

        #region DmxControler
        public bool blackOut = false;
        public float fade = 0.0f;

        [Range(0.0f, 1.0f)]
        public float master = 1.0f;
        #endregion

        [Range(0x00, 0xff)]
        public int dimmerAll;

        #region Faces
        [Range(0x00, 0xff)]
        public int dimmerFaces;

        [Range(0x00, 0xff)]
        public int jardinCour;

        [Range(0x00, 0xff)]
        public int courJardin;

        [Range(0x00, 0xff)]
        public int coldFaces;

        [Range(0x00, 0xff)]
        public int warmFaces;
        #endregion

        #region LEDs
        [Range(0x00, 0xff)]
        public int dimmerLeds;

        [Range(0x00, 0xff)]
        public int dimmerLedJardinCour;

        [Range(0x00, 0xff)]
        public int dimmerLedCourJardin;

        public Color ledsColor = Color.black;
        public Color ledJardinCourColor = Color.black;
        public Color ledCourJardinColor = Color.black;
        #endregion

        #region Strobes
        [Range(0x00, 0xff)]
        public int strobeAll;

        [Range(0x00, 0xff)]
        public int strobeFaces;

        [Range(0x00, 0xff)]
        public int strobeLeds;

        [Range(0x00, 0xff)]
        public int strobeLedsJardinCour;

        [Range(0x00, 0xff)]
        public int strobeLedsCourJardin;

        [Range(0x00, 0xff)]
        public int strobeFaceJardinCour;

        [Range(0x00, 0xff)]
        public int strobeFaceCourJardin;
        #endregion

        private void Awake() => dmxControler = FindObjectOfType<DmxControler>();

        private void Update()
        {
            #region Face Cour -> Jardin
            flatParLedCourJardin.dimmer = Mathf.Max(dimmerAll, dimmerFaces, courJardin);
            flatParLedCourJardin.cold = coldFaces;
            flatParLedCourJardin.warm = warmFaces;
            flatParLedCourJardin.strobe = Mathf.Max(strobeAll, strobeFaces, strobeFaceCourJardin);
            #endregion

            #region Face Jardin -> Cour
            flatParLedJardinCour.dimmer = Mathf.Max(dimmerAll, dimmerFaces, jardinCour);
            flatParLedJardinCour.cold = coldFaces;
            flatParLedJardinCour.warm = warmFaces;
            flatParLedJardinCour.strobe = Mathf.Max(strobeAll, strobeFaces, strobeFaceJardinCour);
            #endregion

            #region Leds Cour -> Jardin
            parLedRgbCourJardin.dimmer = Mathf.Max(dimmerAll, dimmerLeds, dimmerLedCourJardin);
            parLedRgbCourJardin.color = Colors.MaxByChannel(ledsColor, ledCourJardinColor);
            parLedRgbCourJardin.stroboscope = Mathf.Max(strobeAll, strobeLeds, strobeLedsCourJardin);
            #endregion

            #region Leds Jardin -> Cour
            parLedRgbJardinCour.dimmer = Mathf.Max(dimmerAll, dimmerLeds, dimmerLedJardinCour);
            parLedRgbJardinCour.color = Colors.MaxByChannel(ledsColor, ledJardinCourColor);
            parLedRgbJardinCour.stroboscope = Mathf.Max(strobeAll, strobeLeds, strobeLedsJardinCour);
            #endregion
        }
    }
}
