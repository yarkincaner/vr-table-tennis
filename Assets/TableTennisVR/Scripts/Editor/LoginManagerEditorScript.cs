using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LoginManager)), CanEditMultipleObjects]
public class LoginManagerEditorScript : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        EditorGUILayout.HelpBox("This script is responsible for connecting to Photon Servers", MessageType.Info);

        //create a LoginManager variable and set it equal to target. 
        // so this target object is inherited from the Editor class. 
        //and it refers to the inspected object. 
        //in our case, let's cast this target as a Login manager variable. 
        //we can now access the methods from the LoginManager script. 
        LoginManager loginManager = (LoginManager)target;
        if (GUILayout.Button("Connect to Photon"))
        {
            loginManager.ConnectToPhoton();
        }
    }
}
