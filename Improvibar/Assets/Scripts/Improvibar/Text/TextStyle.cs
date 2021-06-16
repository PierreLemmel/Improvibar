using TMPro;
using UnityEngine;

namespace Improvibar.Text
{
    public class TextStyle : MonoBehaviour
    {
        public Color mainColor = Color.white;
        public bool predisplayText;
        public Color predisplayColor = new Color(0.2f, 0.3f, 0.3f, 0.3f);

        public int fontSize = 100;

        public TMP_FontAsset font;
    }
}