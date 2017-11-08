using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//New quests should be added into this Manager Class and when Quests are evaluated and their states changed, again they should be updated within here too. 
//This will require a message to be sent from Quest Objects to this class but also some interaction with the CustomWindow to be created later

//All quests from the inspector should be added to available quests
//All quests that change from inactive to active should move from available to player
//All quests that change to success/failure(chance to restart?) should move from player to finished
public class QuestTracker : MonoBehaviour
{
    //Quest manager should keep track of:
        //What quests haven't been done
        //What quests have been done
        //What quests are 'in progress'
    //String for each quest should be some ID hash perhaps which is immediately indexable so quick to find when speaking to an NPC or similar? 
    //This will also help for moving a quest from available to finished to player. 
    List<Quest> _availableQuests;
    List<Quest> _finishedQuests;
    List<Quest> _playerQuests;

}
