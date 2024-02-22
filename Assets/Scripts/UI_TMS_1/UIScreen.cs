using DG.Tweening;
using System.Collections;
using System.Threading.Tasks;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public abstract class UIScreen : MonoBehaviour
{
    private Image[] imagesToFade;
    private Color[] buttonsColor;
    

    private bool Animate = true;
    public float fadeDuration = 0.5f;


    private void OnEnable()
    {
        imagesToFade = GetComponentsInChildren<Image>();
       
        for (int i = 0; i < imagesToFade.Length ; i++)
        {
            buttonsColor[i] = imagesToFade[i].color;
        }

        if (imagesToFade.Count() < 1)
            Animate = false;
        else
            Animate = true;
    }

    public abstract void SetupScreen(UIScreen previousScreen);

    public virtual void StartScreen()
    {

        gameObject.SetActive(true);

        Color[] buttonsColor = new Color[1];

        for (int i=0; i<buttonsColor.Length - 1; i++)
        {
        
        Color baseColor = new Color(buttonsColor[i].r, buttonsColor[i].g, buttonsColor[i].b, 0);

            imagesToFade[i].color = baseColor;
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



   

