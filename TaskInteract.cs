using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskInteract : Task
{
    //THIS TASK REQUIRES A GAMEOBJECT THAT IS INTERACTABLE
    //THE GAMEOBJECT IS NAMED NPCINTERACTABLE BUT IT NEEDN'T BE AN NPC DEPENDENT ON THE NEEDS OF THE GAME
    //THIS COULD BE USED FOR INTERACTION WITH A SIGN/MESSAGEBOARD/ANY MEDIUM THAT CAN CONVEY MEANING WITHOUT SPEAKING
    public GameObject npcinteractable;

    public override void ActiveProcess()
    {
        //NEED TO KNOW HOW TO CHECK TO SEE INTERACTION HAS GONE CORRECTLY
        if ()
            requirements = true;
    }
}
