using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateFail : State {

    //IF A STATE HAS BEEN FAILED THEN IT SHOULDN'T MOVE FROM INACTIVE TO ACTVE
    public override bool PickUp()
    {
        return false;
    }

    //IF A STATE HAS BEEN FAILED THEN IT SHOULDN'T BE PROCESSED
    public override bool Evaluate()
    {
        return false;
    }

    //IF A STATE HAS BEEN FAILED THEN IT SHOULDN'T MOVED TO SUCCESSFUL
    public override bool HandIn()
    {
        return false;
    }
}
