using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Improvibar
{
    public class ColorPickerBinder : MonoBehaviour
    {
        [SerializeField]
        private FlexibleColorPicker jardinColorPicker;

        [SerializeField]
        private FlexibleColorPicker courColorPicker;

        [SerializeField]
        private FlexibleColorPicker bothColorPicker;

        private CaNeSImprovisePasLights lights;

        private void Awake() => lights = FindObjectOfType<CaNeSImprovisePasLights>();

        public void SetJardinColor(Color color) => jardinColorPicker.SetColor(color);
        public void SetCourColor(Color color) => courColorPicker.SetColor(color);
        public void SetBothColor(Color color) => bothColorPicker.SetColor(color);

        private void Update()
        {
            lights.colorJardin = jardinColorPicker.color;
            lights.colorCour = courColorPicker.color;
            lights.colorBoth = bothColorPicker.color;
        }
    }
}