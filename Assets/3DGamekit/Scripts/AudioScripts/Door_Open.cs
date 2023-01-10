using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Open : MonoBehaviour
{
    public void SimpleTranslator()
    {
        AkSoundEngine.PostEvent("Play_Door", gameObject);
    }
}

