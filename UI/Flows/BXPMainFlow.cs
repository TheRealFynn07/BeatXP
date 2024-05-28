using BeatXP.UI.Views;
using HMUI;
using Zenject;
using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.MenuButtons;
using System;

namespace BeatXP.UI.Flows
{
    class BXPMainFlow : FlowCoordinator, IInitializable, IDisposable
    {
        [Inject] private readonly BXPMainView _bxpMainView;
        [Inject] private readonly MainFlowCoordinator _mainFlowCoordinator;

        private MenuButton _menuButton;

        protected override void DidActivate(bool firstActivation, bool addedToHierarchy, bool screenSystemEnabling)
        {
            if (!firstActivation)
                return;

            SetTitle("Welcome to BeatXP");
            showBackButton = true;

            ProvideInitialViewControllers(_bxpMainView);
        }

        protected override void BackButtonWasPressed(ViewController topViewController) => _mainFlowCoordinator.DismissFlowCoordinator(this);

        internal void ShowFlow() => BeatSaberUI.PresentFlowCoordinator(_mainFlowCoordinator, this);

        public void Initialize()
        {
            _menuButton = new MenuButton("BeatXP", () => _mainFlowCoordinator.PresentFlowCoordinator(this));
            MenuButtons.instance.RegisterButton(_menuButton);
        }

        public void Dispose() => MenuButtons.instance.UnregisterButton(_menuButton);
    }
}