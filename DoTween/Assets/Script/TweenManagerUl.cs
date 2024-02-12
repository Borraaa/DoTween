using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TweenManagerUl : MonoBehaviour
{
    public RectTransform backgraund;

    public float revealDuration = 1f; //ortaya ��karma s�resi

    public RectTransform backgraund2;

    public RectTransform[] upYTrasforms;

    public Text Score;



    void Start()
    {
        //oyunu ba�latt���m�zda ul scale � 0 dan orjinal scale a 1f s�rede geliyor.
        backgraund.DOScale(Vector3.zero, revealDuration).From();

        backgraund2.DOAnchorPosY(250f, revealDuration).From();

        foreach(RectTransform upYTransform in upYTrasforms)
        {
            upYTransform.DOAnchorPosY(-250f, revealDuration).From();
        }

        Score.text = "";
        Score.DOText("10", revealDuration).SetDelay(revealDuration);
        
    }

    public void OnClickTween(RectTransform rectTransform)
    {
        rectTransform.DOScale(rectTransform.localScale * 1.20f, revealDuration / 6f).SetLoops(2, LoopType.Yoyo);
    }
    
}
