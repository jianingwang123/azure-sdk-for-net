// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.DocumentTranslation
{
    /// <summary> Glossary / translation memory for the request. </summary>
    public partial class TranslationGlossary
    {
        /// <summary> Initializes a new instance of TranslationGlossary. </summary>
        /// <param name="glossaryUri">
        /// Location of the glossary.
        /// 
        /// We will use the file extension to extract the formatting if the format parameter is not supplied.
        /// 
        /// 
        /// 
        /// If the translation language pair is not present in the glossary, it will not be applied.
        /// </param>
        /// <param name="format"> Format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="glossaryUri"/> or <paramref name="format"/> is null. </exception>
        public TranslationGlossary(Uri glossaryUri, string format)
        {
            if (glossaryUri == null)
            {
                throw new ArgumentNullException(nameof(glossaryUri));
            }
            if (format == null)
            {
                throw new ArgumentNullException(nameof(format));
            }

            GlossaryUri = glossaryUri;
            Format = format;
        }
    }
}
