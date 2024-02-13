using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public abstract class UIScreen : MonoBehaviour
{
    private Image[] imagesToFade;
    private bool Animate = true;
    public float fadeDuration = 0.5f;


    private void OnEnable()
    {
        imagesToFade = GetComponentsInChildren<Image>();

        if (imagesToFade.Count() < 1)
            Animate = false;
        else
            Animate = true;
    }

    public abstract void SetupScreen(UIScreen previousScreen);

    public virtual void StartScreen()
    {

        Color basecolor = new Color(185, 75, 25, 0);

        gameObject.SetActive(true);

        foreach (var item in imagesToFade)
        {
            item.color = basecolor;

        }

        foreach (var item in imagesToFade)
        {
            item.DOFade(1, fadeDuration);
        }
    }


    public void CloseScreen()
    {
        ClosesCreenWithAwait();
    }

    private async void ClosesCreenWithAwait()
    {
        foreach (var item in imagesToFade)
        {
            item.DOFade(0, fadeDuration);
        }

        await Task.Delay((int)(fadeDuration * 1000));

        gameObject.SetActive(false);
    }
}

