using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Game : UIScreen
{
    [SerializeField] private Button_Logic backGame;
    //[SerializeField] private UIScreen _shopScreen;
    private UIScreen menuScreen;
    
    public override void SetupScreen(UIScreen previousScreen)
    {
        if (menuScreen == null)
            menuScreen = previousScreen;
        

        backGame.AddListener(BackToMenu);
      

    }

     public  void BackToMenu()
    {
        CloseScreen();
        menuScreen.StartScreen();
    }

   
}
