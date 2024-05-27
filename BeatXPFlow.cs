using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMUI;
using BeatSaberMarkupLanguage;

namespace BeatXP
{
    class BeatXPFlow : HMUI.FlowCoordinator
    {

        protected override void DidActivate(bool firstActivation, bool addedToHierarchy, bool screenSystemEnabling)
        {
            if (!firstActivation)
                return;

            SetTitle("BeatXP");
            showBackButton = true;

            ProvideInitialViewControllers(BeatSaberMarkupLanguage.BeatSaberUI.CreateViewController<BeatXPView>());

        }

        protected override void BackButtonWasPressed(ViewController topViewController)
        {
            BeatSaberMarkupLanguage.BeatSaberUI.MainFlowCoordinator.DismissFlowCoordinator(this);
        }

        internal void ShowFlow()
        {
            BeatSaberUI.PresentFlowCoordinator(BeatSaberUI.MainFlowCoordinator.YoungestChildFlowCoordinatorOrSelf(), this);
        }
    }
}