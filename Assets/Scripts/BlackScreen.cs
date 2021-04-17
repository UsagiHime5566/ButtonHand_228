using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BlackScreen : MonoBehaviour
{
    public float duration = 0.7f;
    Image black;

    void Awake(){
        black = GetComponent<Image>();
    }

    public void StartBlackScreen(System.Action callback){
        black.DOFade(1, duration).OnComplete(delegate {
            callback?.Invoke();
            black.DOFade(0, duration);
        });
    }
}
