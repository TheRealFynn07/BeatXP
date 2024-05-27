using BeatXP.UI.Flows;
using BeatXP.UI.Views;
using Zenject;

namespace BeatXP.Installers
{
    internal class MenuInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<BXPMainFlow>().FromNewComponentOnNewGameObject().AsSingle();
            Container.BindInterfacesAndSelfTo<BXPMainView>().FromNewComponentAsViewController().AsSingle();

            Container.BindInterfacesAndSelfTo<BXPTrackFlow>().FromNewComponentOnNewGameObject().AsSingle();
            Container.BindInterfacesAndSelfTo<BXPTrackView>().FromNewComponentAsViewController().AsSingle();
        }
    }
}
