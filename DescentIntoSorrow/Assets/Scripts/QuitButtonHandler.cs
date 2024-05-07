using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This code is used to make the quit button function
public class QuitButtonHandler : MonoBehaviour
{
    // This method is called when the quit button is clicked
    public void OnQuitButtonClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
