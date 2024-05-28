using IPA;
using IPA.Config;
using IPA.Config.Stores;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using IPALogger = IPA.Logging.Logger;
using SiraUtil.Zenject;
using BeatXP.Installers;

namespace BeatXP
{
    [Plugin(RuntimeOptions.SingleStartInit), NoEnableDisable]
    public class Plugin
    {
        [Init]
        public void Init(IPALogger logger, Zenjector zenjector)
        {
            zenjector.UseLogger(logger);
            zenjector.Install<MenuInstaller>(Location.Menu);
        }
    }
}
