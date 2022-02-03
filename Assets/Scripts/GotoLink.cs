using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotoLink : MonoBehaviour
{

    public string ApiURLLink;
    
    public void OpenURL()
    {
        Application.OpenURL(ApiURLLink);
    }
}
