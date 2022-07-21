using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class FadeIn : MonoBehaviour
{
    public Ease Ease_Type; //Easing Type select
    public float duration = 3.0f; // animation time
    public float start_alpha = 1f; //starting oppacity
    public float end_alpha = 0f; // End oppacity

    private void Start()
    {
        CanvasGroup cg = GetComponent < CanvasGroup >();
        cg.alpha = start_alpha;
        cg.DOFade(end_alpha, duration)
        .SetEase(Ease_Type); //EasingType

    }
}
