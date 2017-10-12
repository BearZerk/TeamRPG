using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateInactive : State
{
    //IF A STATE IS INACTIVE THEN IT SHOULD MOVE FROM INACTIVE TO ACTVE WHEN THE PLAYER HAS IT
    public override bool PickUp()
    {
        return true;
    }

    //IF A STATE IS INACTIVE THEN IT SHOULDN'T BE PROCESSED
    public override bool Evaluate()
    {
        return false;
    }

    //IF A STATE IS INACTIVE THEN IT SHOULDN'T MOVE FROM ACTIVE TO SUCCESSFUL
    public override bool HandIn()
    {
        return false;
    }
}
