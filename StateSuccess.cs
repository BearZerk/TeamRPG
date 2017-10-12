using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSuccess : State
{
    //IF A STATE IS SUCCESSFUL THEN IT SHOULDN'T MOVE FROM INACTIVE TO ACTVE
    public override bool PickUp()
    {
        return false;
    }

    //IF A STATE IS SUCCESSFUL THEN IT SHOULDN'T MOVE FROM INACTIVE TO ACTVE
    public override bool Evaluate()
    {
        return false;
    }

    //IF A STATE IS SUCCESSFUL THEN IT SHOULD BE MADE READY TO BE COMPLETE
    public override bool HandIn()
    {
        return true;
    }
}
