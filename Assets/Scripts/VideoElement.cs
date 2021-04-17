using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoElement : MonoBehaviour
{
    public Image ActorName;
    public VideoPlayer ActorVideo;
    public void SetActor(ActorFiles actor){
        ActorName.sprite = actor.nameBoard;
        ActorVideo.clip = actor.video;
        ActorVideo.Play();
    }
}
