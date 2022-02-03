using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GalleryAnima : MonoBehaviour
{

    public bool flag = false;
    public bool AnimaStatus = false;
    public int GalleryAnima_int = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var m_AdelanteButton = GameObject.Find("ButtonSeleccionMenu").GetComponent<Button>();
        m_AdelanteButton.onClick.AddListener(TaskOnClick_Adelante);
        GetComponent<Animator>().SetInteger("GalleryAnima", GalleryAnima_int);

       
        if (AnimaStatus && GalleryAnima_int==1 )
        {
            flag = true;
            m_AdelanteButton.onClick.AddListener(TaskOnClick1_Adelante);

        }

    }

    public void TaskOnClick_Adelante()
    {
        AnimaStatus = true;
        GalleryAnima_int = 1;
    }

    public void TaskOnClick1_Adelante()
    {
        AnimaStatus = false;
        GalleryAnima_int = 0;
    }
}
