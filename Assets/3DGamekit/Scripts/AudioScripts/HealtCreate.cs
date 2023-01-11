using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtCreate : MonoBehaviour
{
    public void onEnter()
    {
        AkSoundEngine.PostEvent("Play_SFX_HealBox", gameObject);
    }
}
