using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Task : ScriptableObject
{
    //ALL TASKS SHOULD HAVE A STATE
    //STATES SHOULD START AS INACTIVE
    //WHEN A PLAYER PICKS UP A QUEST THE FIRST (POTENTIALLY MULTIPLE IF SEVERAL THINGS ARE REQUIRED) TASK SHOULD BECOME ACTIVE AT WHICH POINT WE START CHECKING IF THE REQUIREMENTS HAVE BEEN COMPLETED
    //IF THE REQUIREMENTS ARE DEVIATED FROM (E.G. TIME RESTRICTION / GUARDED NPC DIES - WHATEVER THIS IS EXPANDED TO) THEN THE TASK SHOULD FAIL. RESTARTING ISN'T DECIDED YET (GO BACK TO SQUARE 1?)
    //IF THE REQUIREMENTS ARE KEPT TO (NPC IS SPOKEN TO / TARGET IS KILLED / ITEMS ARE GATHERED / ETC) THEN THE STATE CHANGES TO SUCCESS.
    //AT THIS POINT THE TASK SHOULDN'T NEED FURTHER PROCESSING, ONLY THE QUEST SHOULD CHECK TO SEE IF ALL TASKS ARE COUNTED AS SUCCESS TO VALIDATE A HAND-IN 
    
    //ALL TASKS SHOULD HAVE A TICK() FUNCTION WHICH PROCESSES THEM WHEN THEY'RE MADE ACTIVE

    //ALL TASKS SHOULD HAVE A BOOL TO CONFIRM IF ALL REQUIREMENTS HAVE BE GATHERED AS THERE'S NO NEED TO CHECK ONCE COMPLETED
    public State currentState = new StateInactive();
    public bool requirements = false;

    public void Tick()
    {
        //if the previous state has completed OR the quest has begun
        if ()
        {
            BecomeActive();
        }

        //if the State is Active
        if (currentState.Evaluate())
        {
            ActiveProcess();
        }

        //if the requirements have been fulfilled
        if (requirements)
        {
            BecomeSuccess();
        }
    }

    //NB //// UNAWARE OF IF CHANGING CURRENTSTATE TO NEW STATE TYPES WILL IN ANYWAY CAUSE A MEMORY LEAK BY NOT DELETING THE OLD TYPE?
    public void BecomeActive()
    {
        currentState = new StateActive();
    }

    public abstract void ActiveProcess();

    public void BecomeSuccess()
    {
        currentState = new StateSuccess();
    }
}
