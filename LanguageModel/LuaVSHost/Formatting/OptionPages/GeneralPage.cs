﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.VisualStudio.LuaLanguageService.Formatting.OptionPages.UserControls;
using Microsoft.VisualStudio.LanguageServices.Lua.Shared;

namespace Microsoft.VisualStudio.LanguageServices.Lua.Formatting.OptionPages
{
    [Guid(Guids.GeneralPageString)]
    internal class GeneralPage : BaseDialogPage
    {
        private GeneralUserControl generalUserControl;
        public GeneralPage()
        {
            generalUserControl = new GeneralUserControl();
            generalUserControl.DataContext = UserSettings.MainInstance;
        }

        protected override UIElement Child
        {
            get
            {
                return generalUserControl;
            }
        }
    }
}
