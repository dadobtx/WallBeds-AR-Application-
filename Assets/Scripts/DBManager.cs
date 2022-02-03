using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase.Database;
using Firebase;
using System;

public class DBManager : MonoBehaviour
{

    public GoogleSignInDemo InstanceSessionUser;
    public GameObject SessionUser;


    private DatabaseReference reference;


    // Start is called before the first frame update

    //private
    void Awake()
    {

       reference = FirebaseDatabase.DefaultInstance.RootReference;

    }

    void Start()
    {
        SessionUser = GameObject.Find("Firebase");
        InstanceSessionUser = SessionUser.GetComponent<GoogleSignInDemo>();

        Debug.Log(InstanceSessionUser.entitiesUser.Email);
        Debug.Log(InstanceSessionUser.entitiesUser.UserName);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void WriteFirebase()
    {

        //color
        //cama
        //fecha
        //hora

        string key = reference.Child("Users").Push().Key; //Firebase, Set the array on firebase. The name of "Users" HAVE TO EXISTS on firebase.

        EntitiesUser entitiesUserSet = new EntitiesUser(InstanceSessionUser.entitiesUser.Email, InstanceSessionUser.entitiesUser.Color, InstanceSessionUser.entitiesUser.TypeOfItem, InstanceSessionUser.entitiesUser.UserName, DateTime.Now.ToString("MM/dd/yyyy"), DateTime.Now.ToString("hh:mm:ss"));
        Dictionary<string, object> entitiesUserValues = entitiesUserSet.ToDictionary();

        Dictionary<string, object> childUpdates = new Dictionary<string, object>();
        // childUpdates["/Users/" + key] = entryValues;
        childUpdates["/User-Data/" + InstanceSessionUser.entitiesUser.Color + "/" + key] = entitiesUserValues;
        reference.UpdateChildrenAsync(childUpdates);



    }
    public void TestWrite(string text)
    {
        Debug.Log(text);
    }
}
