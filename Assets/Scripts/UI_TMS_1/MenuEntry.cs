using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEntry: MonoBehaviour
{
    [SerializeField] private UIScreen _mainMenu;

    void Start()
    {
        _mainMenu.StartScreen();
    }
}
