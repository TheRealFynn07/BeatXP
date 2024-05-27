using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;

namespace BeatXP.UI.Views
{
    [HotReload(RelativePathToLayout = @"../TrackView.bsml")]
    [ViewDefinition("BeatXP.UI.TrackView.bsml")]
    internal class BXPTrackView : BSMLAutomaticViewController
    {
    }
}
