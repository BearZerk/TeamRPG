using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateActive : State
{
    //IF A STATE IS ACTIVE THEN IT SHOULDN'T MOVE FROM INACTIVE TO ACTVE
    public override bool PickUp()
    {
        return false;
    }

    //IF A STATE IS ACTIVE THEN IT SHOULD BE PROCESSED
    public override bool Evaluate()
    {
        return true;
    }

    //IF A STATE IS ACTIVE THEN IT SHOULDN'T BE MOVED TO SUCCESS WITHOUT THE REQUIREMENTS BEING FINISHED
    public override bool HandIn()
    {
        return false;
    }
}
