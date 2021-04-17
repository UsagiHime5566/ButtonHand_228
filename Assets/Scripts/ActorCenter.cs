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
    public VideoElement videoElement;
    //靜態影像
    public PhotoElement photoElement;
    //黑幕
    public BlackScreen blackScreen;

    // public VideoPlayer Show_video;
    // public Image Show_nameBoard;    
    // public GameObject ImageBackground;
    // public Image Show_image;
    

    

    void Start(){
        arduino.OnRecieveData += SwitchActor;
    }

    public void SwitchActor(string x){
        if(x != RecieveSymbol)
            return;

        curentIndex = (curentIndex + 1) % actorFiles.Count;

        blackScreen.StartBlackScreen(delegate {
            if(actorFiles[curentIndex].photo != null){
                photoElement.gameObject.SetActive(true);
                photoElement.SetActor(actorFiles[curentIndex]);
            }
            else {
                photoElement.gameObject.SetActive(false);
                videoElement.SetActor(actorFiles[curentIndex]);
            }
        });
    }
}
