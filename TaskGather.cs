using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskGather : Task
{
    //THIS TASK REQUIRES AN ITEM TO BE GATHERED.
    //THIS TASK COULD BE FOR ANY ITEM WITHIN THE GAMEWORLD, HOWEVER IT'S ONLY LOOKING FOR GAMEOBJECTS - MAY NEED TO BUG-PROOF THIS BY HAVING ALL GAMEOBJECTS HAVE A TYPE THAT IS CHECKED
    //THIS COULD THEN CONFIRM THE TASK HAS AN ITEM THAT CAN BE PICKED UP AND NOT AN NPC THAT COULD BE KILLED FOR INSTANCE. 
    //FINALLY THIS TASK REQUIRES A COUNT FOR HOW MANY SHOULD BE GATHERED. IN SOME CASES ONLY 1 ITEM SHOULD EVER SPAWN FOR QUESTS IN SOME CASES MULTIPLE COMMON ITEMS ARE NEEDED.
    //COUNT MUST BE HIGHER THAN 0
    public GameObject worldItem;
    public int worldItemInvCount;
    public int worldItemInvLimit;

    public override void ActiveProcess()
    {
        //NEED A WAY TO CHECK PLAYER INVENTORY
        if (worldItemInvCount == worldItemInvLimit)
            requirements = true;
    }
}