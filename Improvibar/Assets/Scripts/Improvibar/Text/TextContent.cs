using System.Collections.Generic;
using UnityEngine;

namespace Improvibar.Text
{
    public class TextContent : MonoBehaviour
    {
        [SerializeField]
        private List<TextSpan> spans;
        public IReadOnlyCollection<TextSpan> Spans => spans;
    }
}
