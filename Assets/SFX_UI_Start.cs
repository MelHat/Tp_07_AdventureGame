using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_UI_Start : MonoBehaviour
{
    public AK.Wwise.Event clickEvent = null; 
    public void onClick()
    {
        clickEvent.Post(gameObject);
    }
}