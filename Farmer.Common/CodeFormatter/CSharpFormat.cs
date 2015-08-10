﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer.Common
{
    public partial class CSharpFormat : CLikeFormat
    {
        /// <summary>
        /// The list of C# keywords.
        /// </summary>
        protected override string Keywords
        {
            get
            {
                return "abstract as base bool break byte case catch char "
                + "checked class const continue decimal default delegate do double else "
                + "enum event explicit extern false finally fixed float for foreach goto "
                + "if implicit in int interface internal is lock long namespace new null "
                + "object operator out override partial params private protected public readonly "
                + "ref return sbyte sealed short sizeof stackalloc static string struct "
                + "switch this throw true try typeof uint ulong unchecked unsafe ushort "
                + "using value virtual void volatile where while yield";
            }
        }

        /// <summary>
        /// The list of C# preprocessors.
        /// </summary>
        protected override string Preprocessors
        {
            get
            {
                return "#if #else #elif #endif #define #undef #warning "
                    + "#error #line #region #endregion #pragma";
            }
        }
    }
}
