using BeatSaberMarkupLanguage.Components;
using BeatSaberMarkupLanguage.Tags;
using BeatSaberMarkupLanguage.TypeHandlers;
using BeatXP.UI.Views;
using HMUI;
using Zenject;

namespace BeatXP.UI.Flows
{
    internal class BXPInvFlow : FlowCoordinator
    {
        [Inject] private readonly BXPMainFlow _bxpMainFlow;
        [Inject] private readonly BXPInvView _bxpInvView;

        protected override void DidActivate(bool firstActivation, bool addedToHierarchy, bool screenSystemEnabling)
        {
            if (!firstActivation)
                return;

            SetTitle("Inventory");
            showBackButton = true;

            ProvideInitialViewControllers(_bxpInvView);
        }
        protected override void BackButtonWasPressed(ViewController topViewController) => _bxpMainFlow.DismissFlowCoordinator(this);
    }
}
