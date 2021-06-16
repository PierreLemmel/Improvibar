using System;
using UnityEngine;

namespace Improvibar.Text
{
    [Serializable]
    public class TextSpan
    {
        public bool activated = true;

        [TextArea(1, 40)]
        public string content;

        public TextStyle style;
    }
}