using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallEvent : MonoBehaviour
{


    // Update is called once per frame
    public void PlayEvent (string s)
    {
        AkSoundEngine.PostEvent(s, gameObject);
    }
    // Start is called before the first frame update

    void Start()
    {

    }
    void Update()
    {
    }
}
