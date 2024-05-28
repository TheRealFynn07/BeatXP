using BeatSaberMarkupLanguage.Components;
using BeatSaberMarkupLanguage.Tags;
using BeatSaberMarkupLanguage.TypeHandlers;
using BeatXP.UI.Views;
using HMUI;
using Zenject;

namespace BeatXP.UI.Flows
{
    internal class BXPTrackFlow : FlowCoordinator
    {
        [Inject] private readonly BXPMainFlow _bxpMainFlow;
        [Inject] private readonly BXPTrackView _bxpTrackView;

        protected override void DidActivate(bool firstActivation, bool addedToHierarchy, bool screenSystemEnabling)
        {
            if (!firstActivation)
                return;

            SetTitle("Beat Track");
            showBackButton = true;

            ProvideInitialViewControllers(_bxpTrackView);
        }
        protected override void BackButtonWasPressed(ViewController topViewController) => _bxpMainFlow.DismissFlowCoordinator(this);
    }
}
