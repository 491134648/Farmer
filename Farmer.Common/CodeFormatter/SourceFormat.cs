﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Farmer.Common.Html
{
    public abstract partial class SourceFormat
    {
        /// <summary/>
        protected SourceFormat()
        {
            _tabSpaces = 4;
            _lineNumbers = false;
            _alternate = false;
            _embedStyleSheet = false;
        }

        private byte _tabSpaces;

        /// <summary>
        /// Gets or sets the tabs width.
        /// </summary>
        /// <value>The number of space characters to substitute for tab 
        /// characters. The default is <b>4</b>, unless overridden is a 
        /// derived class.</value>
        public byte TabSpaces
        {
            get { return _tabSpaces; }
            set { _tabSpaces = value; }
        }

        private bool _lineNumbers;

        /// <summary>
        /// Enables or disables line numbers in output.
        /// </summary>
        /// <value>When <b>true</b>, line numbers are generated. 
        /// The default is <b>false</b>.</value>
        public bool LineNumbers
        {
            get { return _lineNumbers; }
            set { _lineNumbers = value; }
        }

        private bool _alternate;

        /// <summary>
        /// Enables or disables alternating line background.
        /// </summary>
        /// <value>When <b>true</b>, lines background is alternated. 
        /// The default is <b>false</b>.</value>
        public bool Alternate
        {
            get { return _alternate; }
            set { _alternate = value; }
        }

        private bool _embedStyleSheet;

        /// <summary>
        /// Enables or disables the embedded CSS style sheet.
        /// </summary>
        /// <value>When <b>true</b>, the CSS &lt;style&gt; element is included 
        /// in the HTML output. The default is <b>false</b>.</value>
        public bool EmbedStyleSheet
        {
            get { return _embedStyleSheet; }
            set { _embedStyleSheet = value; }
        }

        /// <overloads>Transform source code to HTML 4.01.</overloads>
        /// 
        /// <summary>
        /// Transforms a source code stream to HTML 4.01.
        /// </summary>
        /// <param name="source">Source code stream.</param>
        /// <returns>A string containing the HTML formatted code.</returns>
        public string FormatCode(Stream source)
        {
            var reader = new StreamReader(source);
            string s = reader.ReadToEnd();
            reader.Close();
            return FormatCode(s, _lineNumbers, _alternate, _embedStyleSheet, false);
        }

        /// <summary>
        /// Transforms a source code string to HTML 4.01.
        /// </summary>
        /// <returns>A string containing the HTML formatted code.</returns>
        public string FormatCode(string source)
        {
            return FormatCode(source, _lineNumbers, _alternate, _embedStyleSheet, false);
        }

        /// <summary>
        /// Allows formatting a part of the code in a different language,
        /// for example a JavaScript block inside an HTML file.
        /// </summary>
        public string FormatSubCode(string source)
        {
            return FormatCode(source, false, false, false, true);
        }

        /// <summary>
        /// Gets the CSS stylesheet as a stream.
        /// </summary>
        /// <returns>A text <see cref="Stream"/> of the CSS definitions.</returns>
        public static Stream GetCssStream()
        {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(
                "Manoli.Utils.CSharpFormat.csharp.css");
        }

        /// <summary>
        /// Gets the CSS stylesheet as a string.
        /// </summary>
        /// <returns>A string containing the CSS definitions.</returns>
        public static string GetCssString()
        {
            var reader = new StreamReader(GetCssStream());
            return reader.ReadToEnd();
        }

        private Regex codeRegex;

        /// <summary>
        /// The regular expression used to capture language tokens.
        /// </summary>
        protected Regex CodeRegex
        {
            get { return codeRegex; }
            set { codeRegex = value; }
        }

        /// <summary>
        /// Called to evaluate the HTML fragment corresponding to each 
        /// matching token in the code.
        /// </summary>
        /// <param name="match">The <see cref="Match"/> resulting from a 
        /// single regular expression match.</param>
        /// <returns>A string containing the HTML code fragment.</returns>
        protected abstract string MatchEval(Match match);

        //does the formatting job
        private string FormatCode(string source, bool lineNumbers,
            bool alternate, bool embedStyleSheet, bool subCode)
        {
            //replace special characters
            var sb = new StringBuilder(source);

            if (!subCode)
            {
                sb.Replace("&", "&amp;");
                sb.Replace("<", "&lt;");
                sb.Replace(">", "&gt;");
                sb.Replace("\t", string.Empty.PadRight(_tabSpaces));
            }

            //color the code
            source = codeRegex.Replace(sb.ToString(), new MatchEvaluator(this.MatchEval));

            sb = new StringBuilder();

            if (embedStyleSheet)
            {
                sb.Append("<style type=\"text/css\">\n");
                sb.Append(GetCssString());
                sb.Append("</style>\n");
            }

            if (lineNumbers || alternate) //we have to process the code line by line
            {
                if (!subCode)
                    sb.Append("<div class=\"csharpcode\">\n");
                var reader = new StringReader(source);
                int i = 0;
                const string spaces = "    ";
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    i++;
                    if (alternate && ((i % 2) == 1))
                    {
                        sb.Append("<pre class=\"alt\">");
                    }
                    else
                    {
                        sb.Append("<pre>");
                    }

                    if (lineNumbers)
                    {
                        var order = (int)Math.Log10(i);
                        sb.Append("<span class=\"lnum\">"
                            + spaces.Substring(0, 3 - order) + i.ToString()
                            + ":  </span>");
                    }

                    if (line.Length == 0)
                        sb.Append("&nbsp;");
                    else
                        sb.Append(line);
                    sb.Append("</pre>\n");
                }
                reader.Close();
                if (!subCode)
                    sb.Append("</div>");
            }
            else
            {
                //have to use a <pre> because IE below ver 6 does not understand 
                //the "white-space: pre" CSS value
                if (!subCode)
                    sb.Append("<pre class=\"csharpcode\">\n");
                sb.Append(source);
                if (!subCode)
                    sb.Append("</pre>");
            }

            return sb.ToString();
        }

    }
}
