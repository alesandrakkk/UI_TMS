using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu: UIScreen
{
    [SerializeField] private Button_Logic _game, _options, _shop;

    [SerializeField] private UIScreen gameScreen;
    [SerializeField] private UIScreen shopScreen;
    [SerializeField] private UIScreen optionsScreen;
    public override void SetupScreen(UIScreen previousScreen) { }
   
    public override void StartScreen()
    {
        base.StartScreen();
        _game.AddListener(StartGame);
        _shop.AddListener(StartShop);
        _options.AddListener(StartOptions);

    }

     private void StartGame()
    {
        Debug.Log("Let's start!");
        gameScreen.SetupScreen(this);

          CloseScreen();

        gameScreen.StartScreen();

    }

     private  void StartShop()
    {
        Debug.Log("Welcome to Shop!");

        shopScreen.SetupScreen(this);

          CloseScreen();

        shopScreen.StartScreen();

    }

    void StartOptions()
    {
        optionsScreen.SetupScreen(this);
        CloseScreen();
        
    }

}
