using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitApp();
        }
    }
    public void ExitApp()
    {
        Application.Quit();
    }
}
