using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Serializable))]
public class SerializableEditor : Editor
{
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System

    public override void OnInspectorGUI()
    {
        Serializable myTarget = (Serializable) base.target;

        GUILayout.Label("SUPER test");

        EditorGUILayout.BeginHorizontal();

        if(GUILayout.Button("Exterminate !"))
        {
            // (Apparently) reset to its default value
            // myTarget.m_student = null;

            myTarget.m_student.m_test++;
        }

        GUILayout.Button("Do nothing!");

        EditorGUILayout.EndHorizontal();

        // Can be drawn before or after (like it is here)
        DrawDefaultInspector();
    }

    #endregion

    #region Class Methods

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
