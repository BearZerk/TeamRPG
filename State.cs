using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : ScriptableObject
{
    //ALL STATES SHOULD RETURN TRUE OR FALSE DEPENDING ON WHAT'S BEING QUERIED
    //IS A STATE READY TO BE PROCESSED? - PICKUP()
    //IS A STATE READY TO BE PROCESSED - EVALUATE()
    //IS A STATE READY TO BE CLOSED? - HANDIN()
    public abstract bool PickUp();
    public abstract bool Evaluate();
    public abstract bool HandIn();

}
