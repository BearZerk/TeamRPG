using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskKill : Task
{
    //THIS TASK REQUIRES A TARGET AND A COUNT. 
    //THIS TASK COULD BE FOR A SINGLE NPC (BOSS/MINIBOSS) OR A REGULARLY OCCURING WORLD NPC (WILD ANIMALS)
    //DEPENDING ON IF THIS TASK IS TO BE USED FOR A SINGLE NPC OR MULTIPLE IT REQUIRES A COUNT WHICH MUST BE MORE THAN 0
    public GameObject npcKill;
    public int npcKillCount;
    public int npcKillLimit;

    public override void ActiveProcess()
    {
        //NEED TO KNOW HOW TO CHECK IF NPCs ARE ACTIVE
        if (npcKillCount == npcKillLimit)
            requirements = true;
    }
}