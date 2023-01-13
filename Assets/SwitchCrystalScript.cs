using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCrystalScript : MonoBehaviour
{
    public void onEnter()
    {
        AkSoundEngine.PostEvent("Play_SFX_Crystal_Activate", gameObject);
    }
}
