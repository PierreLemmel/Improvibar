using Improvibar.Dmx;
using Improvibar.Dmx.Fixtures;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Improvibar
{
    public class CaNeSImprovisePasLights : MonoBehaviour
    {
        #region Fixtures
        [HideInPlayMode]
        [SerializeField]
        private GradateurFixture gradateurPublic;

        [HideInPlayMode]
        [SerializeField]
        private GradateurFixture gradateurFaces;

        [HideInPlayMode]
        [SerializeField]
        private GradateurFixture gradateurContres;


        [HideInPlayMode]
        [SerializeField]
        private WhitePanFixture whitePanJardin;

        [HideInPlayMode]
        [SerializeField]
        private WhitePanFixture whitePanCour;


        [HideInPlayMode]
        [SerializeField]
        private ParLedRGBUv parLedJardin;

        [HideInPlayMode]
        [SerializeField]
        private RgbPizzaFixture pizzaJardin;

        [HideInPlayMode]
        [SerializeField]
        private ParLedRGBUv parLedCour;

        [HideInPlayMode]
        [SerializeField]
        private RgbPizzaFixture pizzaCour;


        private DmxControler dmxControler;
        #endregion


        #region Lights
        #region Gradateur
        [Range(0x00, 0xff)]
        public int publicControl;

        [Range(0x00, 0xff)]
        public int faces;

        [Range(0x00, 0xff)]
        public int contres;
        #endregion

        #region White
        [Range(0x00, 0xff)]
        public int warm;

        [Range(0x00, 0xff)]
        public int cold;

        [Range(0x00, 0xff)]
        public int whiteJar;

        [Range(0x00, 0xff)]
        public int whiteCour;

        [Range(0x00, 0xff)]
        public int whiteBoth;

        [Range(0x00, 0xff)]
        public int strobeWhiteJar;

        [Range(0x00, 0xff)]
        public int strobeWhiteCour;
        #endregion

        #region Colors
        #region Jardin
        public Color colorJardin;

        [Range(0x00, 0xff)]
        public int ledJardinDimmer;

        [Range(0x00, 0xff)]
        public int ledJardinStrobeDimmer;

        [Range(0x00, 0xff)]
        public int ledJardinStroboscope;
        #endregion

        #region Cour
        public Color colorCour;

        [Range(0x00, 0xff)]
        public int ledCourDimmer;

        [Range(0x00, 0xff)]
        public int ledCourStrobeDimmer;

        [Range(0x00, 0xff)]
        public int ledCourStroboscope;
        #endregion

        #region Both
        public Color colorBoth;

        [Range(0x00, 0xff)]
        public int ledBothDimmer;

        [Range(0x00, 0xff)]
        public int ledBothStrobeDimmer;

        [Range(0x00, 0xff)]
        public int ledBothStroboscope;
        #endregion
        #endregion
        #endregion


        #region DmxControler
        public bool blackOut = false;
        public float fade = 0.0f;

        [Range(0.0f, 1.0f)]
        public float master = 1.0f;
        #endregion


        #region Functions
        #region Gradateur
        public void SetPublicControl(float value) => publicControl = (int)value;
        public void SetFaces(float value) => faces = (int)value;
        public void SetContres(float value) => contres = (int)value;
        #endregion

        #region White
        public void SetWarm(float value) => warm = (int)value;
        public void SetCold(float value) => cold = (int)value;
        public void SetWhiteJar(float value) => whiteJar = (int)value;
        public void SetWhiteCour(float value) => whiteCour = (int)value;
        public void SetWhiteBoth(float value) => whiteBoth = (int)value;
        public void SetStrobeWhiteJar(float value) => strobeWhiteJar = (int)value;
        public void SetStrobeWhiteCour(float value) => strobeWhiteCour = (int)value;
        #endregion

        #region Colors
        #region Jardin
        public void SetColorJardin(Color value) => colorJardin = value;
        public void SetLedJardinDimmer(float value) => ledJardinDimmer = (int)value;
        public void SetLedJardinStrobeDimmer(float value) => ledJardinStrobeDimmer = (int)value;
        public void SetLedJardinStroboscope(float value) => ledJardinStroboscope = (int)value;
        #endregion

        #region Cour
        public void SetColorCour(Color value) => colorCour = value;
        public void SetLedCourDimmer(float value) => ledCourDimmer = (int)value;
        public void SetLedCourStrobeDimmer(float value) => ledCourStrobeDimmer = (int)value;
        public void SetLedCourStroboscope(float value) => ledCourStroboscope = (int)value;
        #endregion

        #region Both
        public void SetColorBoth(Color value) => colorBoth = value;
        public void SetLedBothDimmer(float value) => ledBothDimmer = (int)value;
        public void SetLedBothStrobeDimmer(float value) => ledBothStrobeDimmer = (int)value;
        public void SetLedBothStroboscope(float value) => ledBothStroboscope = (int)value;
        #endregion
        #endregion
        #endregion


        private void Awake() => dmxControler = FindObjectOfType<DmxControler>();

        private void Update()
        {
            dmxControler.blackout = blackOut;
            dmxControler.fade = fade;
            dmxControler.master = master;

            #region Gradateur
            gradateurPublic.value = publicControl;
            gradateurFaces.value = faces;
            gradateurContres.value = contres;
            #endregion

            #region White
            whitePanJardin.dimmer = Mathf.Max(whiteJar, whiteBoth);
            whitePanJardin.warm = warm;
            whitePanJardin.cold = cold;
            whitePanJardin.stroboscope = strobeWhiteJar;

            whitePanCour.dimmer = Mathf.Max(whiteCour, whiteBoth);
            whitePanCour.warm = warm;
            whitePanCour.cold = cold;
            whitePanCour.stroboscope = strobeWhiteCour;
            #endregion


            #region Leds
            #region Jardin
            parLedJardin.dimmer = Mathf.Max(ledJardinDimmer, ledJardinStrobeDimmer, ledBothDimmer, ledBothStrobeDimmer);
            parLedJardin.color = Colors.MaxByChannel(colorJardin, colorBoth);
            parLedJardin.stroboscope = Mathf.Max(ledJardinStroboscope, ledBothStroboscope);

            pizzaJardin.dimmer = Mathf.Max(ledJardinDimmer, ledBothDimmer);
            pizzaJardin.color = Colors.MaxByChannel(colorJardin, colorBoth);
            #endregion

            #region Cour
            parLedCour.dimmer = Mathf.Max(ledCourDimmer, ledCourStrobeDimmer, ledBothDimmer, ledBothStrobeDimmer);
            parLedCour.color = Colors.MaxByChannel(colorCour, colorBoth);
            parLedCour.stroboscope = Mathf.Max(ledCourStroboscope, ledBothStroboscope);

            pizzaCour.dimmer = Mathf.Max(ledCourDimmer, ledBothDimmer);
            pizzaCour.color = Colors.MaxByChannel(colorCour, colorBoth);
            #endregion
            #endregion
        }
    }
}