using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

using UText = UnityEngine.UI.Text;

namespace Improvibar
{
    public class SliderBinder : MonoBehaviour
    {
        #region Sliders
        [SerializeField]
        [HideInPlayMode]
        private Slider facesSlider;

        [SerializeField]
        [HideInPlayMode]
        private Slider contresSlider;

        [SerializeField]
        [HideInPlayMode]
        private Slider publicSlider;

        [SerializeField]
        [HideInPlayMode]
        private Slider whiteBothSlider;

        [SerializeField]
        [HideInPlayMode]
        private Slider whiteJardinSlider;

        [SerializeField]
        [HideInPlayMode]
        private Slider whiteCourSlider;

        [SerializeField]
        [HideInPlayMode]
        private Slider whiteWarmSlider;

        [SerializeField]
        [HideInPlayMode]
        private Slider whiteColdSlider;

        [SerializeField]
        [HideInPlayMode]
        private Slider whiteJardinStrobeSlider;

        [SerializeField]
        [HideInPlayMode]
        private Slider whiteCourStrobeSlider;


        [SerializeField]
        [HideInPlayMode]
        private Slider latDimmerBothSlider;

        [SerializeField]
        [HideInPlayMode]
        private Slider latDimmerStrBothSlider;

        [SerializeField]
        [HideInPlayMode]
        private Slider latStrobeBothSlider;


        [SerializeField]
        [HideInPlayMode]
        private Slider latDimmerJardinSlider;

        [SerializeField]
        [HideInPlayMode]
        private Slider latDimmerStrJardinSlider;

        [SerializeField]
        [HideInPlayMode]
        private Slider latStrobeJardinSlider;


        [SerializeField]
        [HideInPlayMode]
        private Slider latDimmerCourSlider;

        [SerializeField]
        [HideInPlayMode]
        private Slider latDimmerStrCourSlider;

        [SerializeField]
        [HideInPlayMode]
        private Slider latStrobeCourSlider;
        #endregion

        [SerializeField]
        [HideInPlayMode]
        private UText speedText;

        private int stepDivider = 1;
        private int step = 1;

        #region KeyCodes
        public KeyCode[] downModifiers = new KeyCode[]
        {
            KeyCode.LeftShift,
            KeyCode.RightShift,
        };

        public KeyCode[] fullModifiers = new KeyCode[]
        {
            KeyCode.LeftControl,
            KeyCode.RightControl,
        };

        public KeyCode[] cutModifiers = new KeyCode[]
        {
            KeyCode.Backspace,
        };

        public KeyCode[] slowModifiers = new KeyCode[]
        {
            KeyCode.RightParen
        };

        public KeyCode[] speedModifiers = new KeyCode[]
        {
            KeyCode.Plus
        };

        public KeyCode facesKey = KeyCode.A;
        public KeyCode contresKey = KeyCode.Q;
        public KeyCode publicKey = KeyCode.W;

        public KeyCode whiteBothKey = KeyCode.Z;
        public KeyCode whiteJardinKey = KeyCode.E;
        public KeyCode whiteCourKey = KeyCode.R;

        public KeyCode whiteWarmKey = KeyCode.S;
        public KeyCode whiteColdKey = KeyCode.D;

        public KeyCode whiteJardinStrobeKey = KeyCode.X;
        public KeyCode whiteCourStrobeKey = KeyCode.C;

        public KeyCode latDimmerBothKey = KeyCode.T;
        public KeyCode latDimmerStrBothKey = KeyCode.Y;
        public KeyCode latStrobeBothKey = KeyCode.U;

        public KeyCode latDimmerJardinKey = KeyCode.I;
        public KeyCode latDimmerStrJardinKey = KeyCode.O;
        public KeyCode latStrobeJardinKey = KeyCode.P;

        public KeyCode latDimmerCourKey = KeyCode.K;
        public KeyCode latDimmerStrCourKey = KeyCode.L;
        public KeyCode latStrobeCourKey = KeyCode.M;

        public KeyCode blackOutKey = KeyCode.Delete;

        public KeyCode dimInKey = KeyCode.PageUp;
        public KeyCode dimOutKey = KeyCode.PageDown;
        #endregion

        private IReadOnlyCollection<(KeyCode key, Slider slider)> keySliders;

        private void Awake() => keySliders = new List<(KeyCode key, Slider slider)>()
        {
            (facesKey, facesSlider),
            (contresKey, contresSlider),
            (publicKey, publicSlider),

            (whiteBothKey, whiteBothSlider),
            (whiteJardinKey, whiteJardinSlider),

            (whiteCourKey, whiteCourSlider),
            (whiteWarmKey, whiteWarmSlider),
            (whiteColdKey, whiteColdSlider),

            (whiteJardinStrobeKey, whiteJardinStrobeSlider),
            (whiteCourStrobeKey, whiteCourStrobeSlider),

            (latDimmerBothKey, latDimmerBothSlider),
            (latDimmerStrBothKey, latDimmerStrBothSlider),
            (latStrobeBothKey, latStrobeBothSlider),

            (latDimmerJardinKey, latDimmerJardinSlider),
            (latDimmerStrJardinKey, latDimmerStrJardinSlider),
            (latStrobeJardinKey, latStrobeJardinSlider),

            (latDimmerCourKey, latDimmerCourSlider),
            (latDimmerStrCourKey, latDimmerStrCourSlider),
            (latStrobeCourKey, latStrobeCourSlider),
        };

        private bool CheckKeys(KeyCode[] keys) => keys.Any(key => Input.GetKey(key));
        private bool CheckKeysDown(KeyCode[] keys) => keys.Any(key => Input.GetKeyDown(key));

        private int GetStepValue() => Time.frameCount % stepDivider == 0 ?
            step : 0;

        private void Update()
        {
            bool cut = CheckKeys(cutModifiers);
            bool full = CheckKeys(fullModifiers);
            bool goDown = CheckKeys(downModifiers);

            if (CheckKeysDown(slowModifiers))
            {
                if (step > 1)
                    step--;
                else
                    stepDivider++;
            }

            if (CheckKeysDown(speedModifiers))
            {
                if (stepDivider > 1)
                    stepDivider--;
                else
                    step++;
            }

            speedText.text = $"Speed: {(float)step/stepDivider}";

            int stepValue = GetStepValue();

            foreach ((KeyCode key, Slider slider) in keySliders)
            {
                if (Input.GetKey(key))
                {
                    if (cut)
                    {
                        slider.value = 0;
                    }
                    else if (full)
                    {
                        slider.value = 0xff;
                    }
                    else if (goDown)
                    {
                        slider.value = Mathf.Max(slider.value - stepValue, 0x00);
                    }
                    else
                    {
                        slider.value = Mathf.Min(slider.value + stepValue, 0xff);
                    }
                }
            }

            if (Input.GetKeyDown(blackOutKey))
            {
                foreach((_, Slider slider) in keySliders)
                {
                    slider.value = 0.0f;
                }
            }

            if (Input.GetKey(dimInKey))
            {
                foreach ((_, Slider slider) in keySliders)
                {
                    if (slider.value != 0.0f)
                    {
                        slider.value = Mathf.Min(slider.value + stepValue, 0xff);
                    }
                }
            }

            if (Input.GetKey(dimOutKey))
            {
                foreach ((_, Slider slider) in keySliders)
                {
                    slider.value = Mathf.Max(slider.value - stepValue, 0x00);
                }
            }
        }
    }
}