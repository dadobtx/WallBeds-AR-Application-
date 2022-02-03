using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourColor : MonoBehaviour
{

    //Session User
    public GoogleSignInDemo InstanceSessionUser;
    public GameObject SessionUser;
    //end Session User
    public DBManager InstanceDBManager;
    public GameObject SessionDBManager;

    // Start is called before the first frame update
    void Start()
    {

        SessionUser = GameObject.Find("Firebase");
        InstanceSessionUser = SessionUser.GetComponent<GoogleSignInDemo>();

        SessionDBManager = GameObject.Find("DBManager");
        InstanceDBManager = SessionDBManager.GetComponent<DBManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ChangeItemColor(string Color)
    {
        
        InstanceSessionUser.entitiesUser.Color = Color;
        InstanceDBManager.WriteFirebase();
        
    }


}
