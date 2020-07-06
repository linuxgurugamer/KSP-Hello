
using UnityEngine;

namespace KSP_Hello
{
    [KSPAddon(KSPAddon.Startup.SpaceCentre, false)]
    public class KSPHello : MonoBehaviour
    {

        void Awake()
        {
            // This get run first with all the other Awakes
        }

        void Start()
        {
            // This get run next after all the Awakes are run
        }


        void Update()
        {
            // This is one of the main processing loops, called continously
        }


        void LateUpdate()
        {
            // Similar to Update, except runs after all the Updates
        }

        void FixedUpdate()
        {
            // Runs once every physics cycle, about 50/sec
        }

        bool visible = true;
        Rect windowPos = new Rect(500, 500, 300, 200);

        // OnGUI has all the GUI stuff
        void OnGUI()
        {
            if (visible)
                windowPos = GUILayout.Window(12345693, windowPos, WindowGUI, "KSP Hello World ");

        }

        void WindowGUI(int id)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label("Hello, KSP");
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("OK"))
            {
                visible = false;
            }
            GUILayout.EndHorizontal();
            GUI.DragWindow();
        }

    }
}
