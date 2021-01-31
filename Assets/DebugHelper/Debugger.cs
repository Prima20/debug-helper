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

        #region Singleton
        private static Debugger _instance = null;

        public static Debugger Instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject go = new GameObject("DebugHelper", typeof(Debugger));
                    _instance = go.GetComponent<Debugger>();
                }

                return _instance;
            }
        }
        #endregion

        public void Log(object message)
        {
            logMessage += message + "\n";
            Debug.Log(message);
        }

        public void Log(object message, Object context)
        {
            logMessage += message + "\n";
            Debug.Log(message, context);
        }


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
