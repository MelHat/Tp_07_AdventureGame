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
    //La fonction PlayEvent existe déjà dans un autre script utilisé par le Grenadier donc voilà une autre fonction qui fait exactement la même chose
    public void PlayWwiseEvent (string s)
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
