using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_UI_Start : MonoBehaviour
{
    public void onClick()
    {
        AkSoundEngine.PostEvent("Play_SFX_UI_Start", gameObject);
    }
}