using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EntitiesUser
{
    public string Email;
    public string Color;
    public string TypeOfItem;
    public string UserName;
    public string Date;
    public string Hour;



    public EntitiesUser(string Email, string Color, string TypeOfItem, string UserName, string Date, string Hour)
    {
        this.Email = Email;
        this.Color = Color;
        this.TypeOfItem = TypeOfItem;
        this.UserName = UserName;
        this.Date = Date;
        this.Hour = Hour;
    }

    public Dictionary<string, object> ToDictionary()
    {
        Dictionary<string, object> result = new Dictionary<string, object>();
        result["Email"] = Email;
        result["UserName"] = UserName;
        result["Color"] = Color;
        result["TypeOfItem"] = TypeOfItem;
        result["Date"] = Date;
        result["Hour"] = Hour;

        return result;
    }
}