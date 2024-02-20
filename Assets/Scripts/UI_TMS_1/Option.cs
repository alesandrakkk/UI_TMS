using System.Collections;
using UnityEngine;

namespace Assets.Scripts.UI_TMS_1
{
     public  class Option: UIScreen
     {
        [SerializeField] private Button_Logic backButton;
        private UIScreen menuScreen;

        public override void SetupScreen(UIScreen previousScreen)
        {
            if (menuScreen == null)
                menuScreen = previousScreen;
            base.StartScreen();

            backButton.AddListener(BackToMenu);
        }

        private  void BackToMenu()
        {
            CloseScreen();
            menuScreen.StartScreen();
        }


        
          
        
     }
}