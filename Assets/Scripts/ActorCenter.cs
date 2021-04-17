using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ActorCenter : HimeLib.SingletonMono<ActorCenter>
{
    public ArduinoInteractive arduino;
    public string RecieveSymbol = "7";
    public List<ActorFiles> actorFiles;
    public int curentIndex;

    [Header("Target View")]
    
    //動態影像
    public VideoPlayer Show_video;
    public Image Show_nameBoard;
    
    //靜態影像
    public GameObject ImageBackground;
    public Image Show_image;
    

    

    void Start(){
        arduino.OnRecieveData += SwitchActor;
    }

    public void SwitchActor(string x){
        if(x != RecieveSymbol)
            return;

        //Debug.Log("Switch!");

        curentIndex = (curentIndex + 1) % actorFiles.Count;
        if(actorFiles[curentIndex].photo != null){
            ImageBackground.SetActive(true);
            Show_image.sprite = actorFiles[curentIndex].photo;
        }
        else {
            ImageBackground.SetActive(false);
            Show_nameBoard.sprite = actorFiles[curentIndex].nameBoard;
            Show_video.clip = actorFiles[curentIndex].video;
            Show_video.Play();
        }
    }
}
