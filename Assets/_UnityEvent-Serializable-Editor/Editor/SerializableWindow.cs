using UnityEngine;
using UnityEditor;
using System.Collections;

class MyWindow : EditorWindow
{
    // Use static so it persists when closing the window
    // (Doesn't persist on Unity restart)
    static public GameObject poney;

    [MenuItem("Window/My Window")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(MyWindow));
    }

    void OnGUI()
    {
        poney = EditorGUILayout.ObjectField("Kikou", poney, typeof(GameObject), true) as GameObject;
        // Etc

        if(GUILayout.Button("Coucou") && poney != null)
        {
            Instantiate(poney);
        }
    }
}