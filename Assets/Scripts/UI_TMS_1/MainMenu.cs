using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu: UIScreen
{
    [SerializeField] private Button_Logic _game, _options, _shop;

    [SerializeField] private UIScreen gameScreen;
    public override void SetupScreen(UIScreen previousScreen)
    {
        Debug.Log("Ubejtie pozhalujsta");
    }

    public override void StartScreen()
    {
        base.StartScreen();
        _game.AddListener(StartGame);

    }

    void StartGame()
    {
        Debug.Log("Welcome!");

        CloseScreen();
    }

}
