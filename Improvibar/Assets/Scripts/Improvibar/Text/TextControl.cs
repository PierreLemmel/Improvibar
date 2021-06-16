using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using System.Text;
using System;
using System.Linq;

namespace Improvibar.Text
{
    public class TextControl : MonoBehaviour
    {
        private TMP_Text textMesh;
        private TextContent textContent;
        private TextControlConfig config;

        private IList<Block> blocks = new List<Block>();
        private int LastBlockIdx => blocks.Count - 1;

        private bool started = false;
        private int blockIdx;
        private int syllableIdx;

        private void Awake()
        {
            textMesh = FindObjectOfType<TMP_Text>();
            config = FindObjectOfType<TextControlConfig>();
            textContent = FindObjectOfType<TextContent>();
        }

        private void Start()
        {
            Setup();
        }

        private void Update()
        {
            if (Input.GetKeyDown(config.NextKey)) NextElement();
            if (Input.GetKeyDown(config.PreviousKey)) PreviousElement();
            if (Input.GetKeyDown(config.ResetKey)) Reinitialize();
        }

        private void NextElement()
        {
            if (!started)
            {
                started = true;
            }
            else if (syllableIdx < blocks[blockIdx].LastSyllableIdx)
            {
                syllableIdx++;
            }
            else if (blockIdx < LastBlockIdx)
            {
                blockIdx++;
                syllableIdx = 0;
            }


            Display();
        }

        private void PreviousElement()
        {
            if (syllableIdx > 0)
            {
                syllableIdx--;
            }
            else if (blockIdx > 0)
            {
                blockIdx--;
                syllableIdx = blocks[blockIdx].LastSyllableIdx;
            }
            else
            {
                started = false;
            }

            Display();
        }

        private void Reinitialize() => Setup();

        private void Setup()
        {
            string[] blockSeparators = new[] { config.ClearSeparator, "\n" };
            char syllableSeparator = config.SyllableSeparator.Single();
            foreach (TextSpan span in textContent.Spans)
            {
                if (!span.activated) continue;

                TextStyle style = span.style;

                string[] blockContents = span.content.Split(blockSeparators, StringSplitOptions.RemoveEmptyEntries);
                foreach(string block in blockContents)
                {
                    int maxIdx = block.Length;
                    List<Syllable> syllables = new List<Syllable>();

                    int from = 0;
                    int current = 0;
                    void AddSyllable(bool hasSpace = false)
                    {
                        syllables.Add(new Syllable(block.Substring(from, current - from), hasSpace: hasSpace));

                        from = current + 1;
                        current = from;
                    }

                    while (current < maxIdx)
                    {
                        char c = block[current];

                        if (c == syllableSeparator)
                            AddSyllable();
                        else if (c == ' ')
                            AddSyllable(hasSpace: true);
                        else
                            current++;
                    }

                    AddSyllable();

                    blocks.Add(new Block(syllables, style));
                }
            }
            
            started = false;
            blockIdx = 0;
            syllableIdx = 0;

            Display();
        }

        private StringBuilder sb = new StringBuilder();
        private void Display()
        {
            string text;
            if (started)
            {
                sb.Clear();

                Block block = blocks[blockIdx];
                TextStyle style = block.Style;

                bool predisplay = style.predisplayText;

                textMesh.font = style.font;
                textMesh.fontSize = style.fontSize;
                textMesh.fontSizeMax = style.fontSize;
                textMesh.richText = predisplay;

                void StartColor(Color color) => sb.Append($"<color={color.ToHex()}>");
                void StopColor() => sb.Append("</color>");
                void AppendSyllable(Syllable syllable)
                {
                    sb.Append(syllable.Content);
                    if (syllable.HasSpace)
                        sb.Append(' ');
                }


                if (predisplay)
                    StartColor(style.mainColor);

                IReadOnlyList<Syllable> syllables = block.Syllables;


                for (int i = 0; i <= syllableIdx; i++)
                    AppendSyllable(syllables[i]);

                if (predisplay)
                {
                    StopColor();
                    StartColor(style.predisplayColor);
                    for (int i = syllableIdx + 1; i <= block.LastSyllableIdx; i++)
                        AppendSyllable(syllables[i]);
                    StopColor();
                }

                text = sb.ToString();
            }
            else
            {
                text = "";
            }

            textMesh.text = text;
        }

        private class Block
        {
            public Block(IReadOnlyList<Syllable> syllables, TextStyle style)
            {
                Syllables = syllables;
                Style = style;
            }

            public IReadOnlyList<Syllable> Syllables { get; }
            public TextStyle Style { get; }
            public int LastSyllableIdx => Syllables.Count - 1;
        }

        private struct Syllable
        {
            public Syllable(string content, bool hasSpace = false)
            {
                Content = content;

                HasSpace = hasSpace;
            }

            public string Content { get; }

            public bool HasSpace { get; }
        }
    }
}