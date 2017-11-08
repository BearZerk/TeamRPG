using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : ScriptableObject
{
    //Every quest object will have:
        //An ID - perhaps a hash (too complex for our needs?)
        //A name/title - Old Jake
        //A description - Kill Old Jake
        //A dictionary for each task component (is it worth keeping this as a list?) (Keep an eye on TasksMain type as this may change as tasks are fleshed out)
            //Go to NPC to pick up/start quest
            //Go to Map Co-ords
            //Kill Jake
            //Gather Jakes head
            //Go back to original NPC to hand in
            //etc
    //This can be expanded upon
    string _id;
    string _name;
    string _description;
    List<Task> _tasks;

    //Constructor for when we create a new Quest
    public Quest(string newID, string newName, string newDescription, List<Task> newTask)
    {
        _id = newID;
        _name = newName;
        _description = newDescription;
        _tasks = newTask;
    }

    //Evaluate method in order to determine if the Quest is completed
    public void UpdateState()
    {
        foreach (Task task in _tasks)
        {
            //IF task STATE != COMPLETE
            //EXIT
            //ELSE (all tasks must have been completed)
            //CHANGE STATE

            //^^ The above here is dependant on how the FSM is implemented with TASKS
            //This class needs to be updated to include FSM type behaviour as well for tracking purposes
        }
    }
}