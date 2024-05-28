using BeatSaberMarkupLanguage.Components;
using BeatSaberMarkupLanguage.Tags;
using BeatSaberMarkupLanguage.TypeHandlers;
using BeatXP.UI.Views;
using HMUI;
using Zenject;

namespace BeatXP.UI.Flows
{
    internal class BXPShopFlow : FlowCoordinator
    {
        [Inject] private readonly BXPMainFlow _bxpMainFlow;
        [Inject] private readonly BXPShopView _bxpShopView;

        protected override void DidActivate(bool firstActivation, bool addedToHierarchy, bool screenSystemEnabling)
        {
            if (!firstActivation)
                return;

            SetTitle("Item Shop");
            showBackButton = true;

            ProvideInitialViewControllers(_bxpShopView);
        }
        protected override void BackButtonWasPressed(ViewController topViewController) => _bxpMainFlow.DismissFlowCoordinator(this);
    }
}
