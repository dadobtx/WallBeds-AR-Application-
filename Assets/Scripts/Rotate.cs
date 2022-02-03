using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    public bool flag = false;
    public bool flag_adel = false;
    public bool flag_atra = false;
    //public Button m_AdelanteButton, m_AtrasButton;
    public int rotate = 1;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //var m_AdelanteButton = GameObject.Find("AdelanteButton").GetComponent<Button>();
        //var m_AtrasButton = GameObject.Find("AtrasButton").GetComponent<Button>();
        var Slider = GameObject.Find("Slider1").GetComponent<Slider>();

        //m_AdelanteButton.onClick.AddListener(TaskOnClick_Adelante);
        //m_AtrasButton.onClick.AddListener(TaskOnClick_Atras);

        /* if (Input.GetKeyUp(KeyCode.DownArrow) || flag_atra)
         {

             flag = true;
             //rotate = 1;
             if (rotate > 1)
             {
                 rotate--;
             }
             else { rotate = 1; }
             //GetComponent<Animator>().SetBool("Click1", flag);
             GetComponent<Animator>().SetInteger("Anima", rotate);

             flag_atra = false;
             Debug.Log("Cambio abajo");



         }

         if (Input.GetKeyUp(KeyCode.UpArrow) ||flag_adel)
         {

             flag = false;
             //rotate = 2;
             rotate++;
             //GetComponent<Animator>().SetBool("Click1", flag);
             GetComponent<Animator>().SetInteger("Anima", rotate);
             flag_adel = false;
             Debug.Log("Cambio arriba");

         }*/

        //Slider.value = rotate;
        rotate = (int)Slider.value;
        GetComponent<Animator>().SetInteger("Anima", rotate);

    }

    void TaskOnClick_Adelante()
    {
        flag_adel = true;
        flag_atra = false;
    }

    void TaskOnClick_Atras()
    {
        flag_adel = false;
        flag_atra = true;
    }

    /*public void AnimaAdelante()
    {
        flag = false;
        //rotate = 2;
        rotate++;
        //GetComponent<Animator>().SetBool("Click1", flag);
        GetComponent<Animator>().SetInteger("Anima", rotate);
        flag_adel = false;
        Debug.Log("Cambio arriba");
    }

    public void AnimaAtras()
    {
        flag = true;
        //rotate = 1;
        if (rotate > 1)
        {
            rotate--;
        }
        else { rotate = 1; }
        //GetComponent<Animator>().SetBool("Click1", flag);
        GetComponent<Animator>().SetInteger("Anima", rotate);

        flag_atra = false;
        Debug.Log("Cambio abajo");

    }*/
}
