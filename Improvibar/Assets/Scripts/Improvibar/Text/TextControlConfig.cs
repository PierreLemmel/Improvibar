using UnityEngine;

namespace Improvibar.Text
{
    public class TextControlConfig : MonoBehaviour
    {
        [SerializeField]
        private string syllableSeparator = "-";
        public string SyllableSeparator => syllableSeparator;


        [SerializeField]
        private string clearSeparator = "|";
        public string ClearSeparator => clearSeparator;


        [SerializeField]
        private KeyCode nextKey = KeyCode.Alpha1;
        public KeyCode NextKey => nextKey;

        [SerializeField]
        private KeyCode previousKey = KeyCode.Alpha2;
        public KeyCode PreviousKey => previousKey;

        [SerializeField]
        private KeyCode resetKey = KeyCode.Alpha3;
        public KeyCode ResetKey => resetKey;
    }
}