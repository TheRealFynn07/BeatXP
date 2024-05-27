using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using BeatSaberMarkupLanguage.ViewControllers;
using BeatSaberMarkupLanguage.Attributes;

namespace BeatXP
{
    [HotReload(RelativePathToLayout = @"./UI/UI.bsml")]
    [ViewDefinition("BeatXP.UI.bsml")]
    class BeatXPView : BSMLAutomaticViewController
    {
        void OpenDiscordLink() => Process.Start("https://discord.gg/tbJTZjjf6d");
    }
}
