using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public abstract class Button_Logic : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    protected Action onClick;
    public Image targetGraphic;
    private Vector2 startScale;
    public float animationModificator = 1.1f;

    void OnEnable()
    {
        targetGraphic = GetComponent<Image>();

        startScale = transform.localScale;
    }

    public void AddListener(Action onClick)
    {
        this.onClick = onClick;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.localScale *= animationModificator;

        onClick?.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.localScale = startScale;
    }
}
