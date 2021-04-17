using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoElement : MonoBehaviour
{
    public Image ActorName;
    public Image ActorPicture;
    public AspectRatioFitter ActorPictureRatio;
    
    public void SetActor(ActorFiles actor){
        ActorName.sprite = actor.nameBoard;
        ActorPicture.sprite = actor.photo;
        ActorPictureRatio.aspectRatio = (float)ActorPicture.sprite.rect.width / ActorPicture.sprite.rect.height;
        //ActorPictureRatio.aspectMode = AspectRatioFitter.AspectMode.None;
        //ActorPicture.SetNativeSize();
        //ActorPictureRatio.aspectMode = AspectRatioFitter.AspectMode.FitInParent;
    }
}
