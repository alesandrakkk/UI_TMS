using DG.Tweening;
using System.Collections;
using System.Threading.Tasks;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public abstract class UIScreen : MonoBehaviour
{
    private Image[] imagesToFade;
    //private Color[] buttonsColor;
    

    private bool Animate = true;
    public float fadeDuration = 0.5f;


    private void OnEnable()
    {
          
        imagesToFade = GetComponentsInChildren<Image>();

        //for (int i =0; i< imagesToFade.Length; i++)
        //{
        //    buttonsColor[i] = imagesToFade;
        //}

        if (imagesToFade.Count() < 1)
            Animate = false;
        else
            Animate = true;
    }

    public abstract void SetupScreen(UIScreen previousScreen);

    public virtual void StartScreen()
    {
        Color baseColor = new Color(255, 255, 255, 0);

        gameObject.SetActive(true);

        foreach (var item in imagesToFade)
        {
            item.color = baseColor;
        }

        foreach (var item in imagesToFade)
        {
            item.DOFade(1, fadeDuration);
        }
    }
    public void CloseScreen()
    {
         CloseScreenAnimation();
    }
    private async Task CloseScreenAnimation()
    {
        foreach (var item in imagesToFade)
        {
            item.DOFade(0, fadeDuration);
        }

        await Task.Delay((int)(fadeDuration * 1000));

        gameObject.SetActive(false);
    }
}



   

