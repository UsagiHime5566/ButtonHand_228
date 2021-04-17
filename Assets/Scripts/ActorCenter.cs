using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorCenter : HimeLib.SingletonMono<ActorCenter>
{
    public ArduinoInteractive arduino;
    public string RecieveSymbol = "7";
    public List<ActorFiles> actorFiles;
    public int curentIndex;

    

    void Start(){
        arduino.OnRecieveData += SwitchActor;
    }

    public void SwitchActor(string x){
        if(x != RecieveSymbol)
            return;

        Debug.Log("Switch!");
    }
}
