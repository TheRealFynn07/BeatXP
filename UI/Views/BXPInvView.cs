using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;

namespace BeatXP.UI.Views
{
    [HotReload(RelativePathToLayout = @"../InvView.bsml")]
    [ViewDefinition("BeatXP.UI.InvView.bsml")]
    internal class BXPInvView : BSMLAutomaticViewController
    {
    }
}
