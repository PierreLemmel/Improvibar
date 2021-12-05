using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Improvibar
{
    public class SpectacleAlice : MonoBehaviour
    {
        private CaNeSImprovisePasLights lights;
        private ColorPickerBinder colorBinder;

        [Range(0x00, 0xff)]
        public int facesIntro = 127;
        public Color colorIntro = Color.blue;
        
        [Range(0x00, 0xff)]
        public int dimmerColorIntro = 200;

        [Range(0x00, 0xff)]
        public int facesTableaux = 200;

        [Range(0x00, 0xff)]
        public int facesNormal = 200;

        [Range(0x00, 0xff)]
        public int decrochageFaces = 50;
        [Range(0x00, 0xff)]
        public int decrochageLedsDimmer = 0xff;

        public Color colorDesert;
        public Color colorMer;
        public Color colorForet;

        private void Awake()
        {
            lights = FindObjectOfType<CaNeSImprovisePasLights>();
            colorBinder = FindObjectOfType<ColorPickerBinder>();
        }

        public void Debut()
        {
            ResetLights();
            LumiereIntroFin();
        }

        private bool tableaux = false;
        public void Tableaux()
        {
            ResetLights();

            tableaux = !tableaux;
            if (tableaux)
                lights.faces = facesTableaux;
        }

        public void Decrochage()
        {
            ResetLights();

            float hue1 = Random.Range(0.0f, 1.0f);
            float hue2 = hue1 < 0.5f ? (hue1 + 0.5f) : (hue1 - 0.5f);

            Color color1 = Color.HSVToRGB(hue1, 1.0f, 1.0f);
            Color color2 = Color.HSVToRGB(hue2, 1.0f, 1.0f);

            colorBinder.SetJardinColor(color1);
            colorBinder.SetCourColor(color2);

            lights.faces = decrochageFaces;
            lights.ledBothDimmer = decrochageLedsDimmer;
        }

        public void Normalite()
        {
            ResetLights();
            lights.faces = facesNormal;
        }

        public void Fin()
        {
            ResetLights();
            LumiereIntroFin();
        }

        public void BlackOut()
        {
            lights.faces = 0;
            lights.ledBothDimmer = 0;
            lights.whiteJar = 0;
            lights.whiteCour = 0;
            lights.whiteBoth = 0;

            colorBinder.SetJardinColor(Color.black);
            colorBinder.SetCourColor(Color.black);
        }


        public void Foret() => colorBinder.SetBothColor(colorForet);
        public void Desert() => colorBinder.SetBothColor(colorDesert);
        public void Mer() => colorBinder.SetBothColor(colorMer);

        private void LumiereIntroFin()
        {
            colorBinder.SetCourColor(colorIntro);
            colorBinder.SetJardinColor(colorIntro);

            lights.ledBothDimmer = dimmerColorIntro;
            lights.faces = facesIntro;
        }

        private void ResetLights()
        {
            lights.faces = 0;
            lights.ledBothDimmer = 0;
            lights.whiteJar = 0;

            colorBinder.SetJardinColor(Color.black);
            colorBinder.SetCourColor(Color.black);
        }
    }
}
