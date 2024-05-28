using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;

namespace BeatXP.UI.Views
{
    [HotReload(RelativePathToLayout = @"../ShopView.bsml")]
    [ViewDefinition("BeatXP.UI.ShopView.bsml")]
    internal class BXPShopView : BSMLAutomaticViewController
    {
    }
}
