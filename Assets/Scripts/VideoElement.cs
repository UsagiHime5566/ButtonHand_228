using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoElement : MonoBehaviour
{
    public Image ActorName;
    public VideoPlayer ActorVideo;
    public Vector2 BaseNameOffset = new Vector2(150, 25);
    public void SetActor(ActorFiles actor){
        ActorName.sprite = actor.nameBoard;
        ActorVideo.clip = actor.video;
        ActorVideo.Play();

        ActorName.rectTransform.anchoredPosition = BaseNameOffset + actor.BoardOffset;
    }
}
