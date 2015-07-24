﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Utilities;

namespace Microsoft.VisualStudio.LuaLanguageService.Shared
{
    internal static class ContentTypes
    {
        [Export]
        [Name(Constants.LanguageName)]
        [BaseDefinition("code")]
        internal static ContentTypeDefinition ContentType { get; set; }

        [Export]
        [FileExtension(Constants.FileExtension)]
        [ContentType(Constants.LanguageName)]
        internal static FileExtensionToContentTypeDefinition LuaContentTypeExtensionDefinition { get; set; }
    }
}