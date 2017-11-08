using UnityEngine;
using UnityEditor;

public class QuestEditor : EditorWindow
{

    [MenuItem("Window/Quest Editor")]
    public static void CreateEditor()
    {
        EditorWindow.GetWindow<QuestEditor>("Quest Editor");
    }

    private void OnGUI()
    {
        //Do Quest Stuff
    }

}
