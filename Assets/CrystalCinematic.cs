using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalCinematic : MonoBehaviour
{
    public void onEnter()
    {
        AkSoundEngine.PostEvent("Play_SFX_Crystal_Activate", gameObject);
        AkSoundEngine.PostEvent("Play_LargeDoor_02", gameObject);
    }
}
