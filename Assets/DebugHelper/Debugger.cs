using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DebugHelper
{
    public class Debugger : MonoBehaviour
    {
        private Vector2 scrollPosition;

        private float xPos = Screen.width * 0.05f;
        private float yPos = Screen.height - (180f);

        private float winWidth = 180f;
        private float winHeight = 150f;

        private string logMessage = "";


        void OnGUI()
        {
            GUILayout.BeginArea(new Rect(xPos, yPos, winWidth, winHeight));
            scrollPosition = GUILayout.BeginScrollView(
                scrollPosition, false, true, GUILayout.Width(winWidth), GUILayout.Height(winHeight));
            
            GUILayout.Label("Debugger Window");
            GUILayout.Label(logMessage);

            if (GUILayout.Button("Clear"))
                logMessage = "";

            GUILayout.EndScrollView();
            GUILayout.EndArea();
        }
    }
}
