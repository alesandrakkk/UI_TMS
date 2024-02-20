using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.UI_TMS_1
{
    public class Shopscreen : UIScreen
    {
        [SerializeField] private Button_Logic back;

        private UIScreen menuScreen;

        public override void SetupScreen(UIScreen previousScreen)
        {
            if (menuScreen == null)
                menuScreen = previousScreen;


            back.AddListener(BackToMenu);
        }

        public void BackToMenu()
        {
            CloseScreen();
            menuScreen.StartScreen();
        }
    }
}