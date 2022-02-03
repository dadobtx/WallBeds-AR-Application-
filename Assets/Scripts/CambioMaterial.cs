using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioMaterial : MonoBehaviour
{
    // Start is called before the first frame update

    public Material Haya, Wengue, Blanco, Cerezo;
    //public Button CafeButton, NegroButton,BlancoButton;
    public int selector = 0;
    //public ClaseDatos claseDatos;

  

    // Update is called once per frame
    void Update()
    {
        var HayaButton = GameObject.Find("Haya").GetComponent<Button>();
        var WengueButton = GameObject.Find("Wengue").GetComponent<Button>();
        var BlancoButton = GameObject.Find("White").GetComponent<Button>();
        var CerezoButton = GameObject.Find("Cerezo").GetComponent<Button>();

        HayaButton.onClick.AddListener(TaskOnClick_Haya);
        WengueButton.onClick.AddListener(TaskOnClick_Wengue);
        BlancoButton.onClick.AddListener(TaskOnClick_Blanco);
        CerezoButton.onClick.AddListener(TaskOnClick_Cerezo);
        switch (selector)
        {
            case 4:
                gameObject.GetComponent<Renderer>().material = Wengue;
                //claseDatos.color = "Wengue";
                break;

            case 3:
                gameObject.GetComponent<Renderer>().material = Haya;
                //claseDatos.color = "Haya";
                break;

            case 2:
                gameObject.GetComponent<Renderer>().material = Blanco;
                //claseDatos.color = "Blanco";
                break;

            case 1:
                gameObject.GetComponent<Renderer>().material = Cerezo;
                //claseDatos.color = "Cerezo";
                break;

            default:
                gameObject.GetComponent<Renderer>().material = Blanco;
                //claseDatos.color = "Blanco";
                break;

        }
    }

    void TaskOnClick_Haya()
    {
        selector = 3;
    }

    void TaskOnClick_Wengue()
    {
        selector = 4;
    }

    void TaskOnClick_Blanco()
    {
        selector = 2;
    }

    void TaskOnClick_Cerezo()
    {
        selector = 1;

    }
}
