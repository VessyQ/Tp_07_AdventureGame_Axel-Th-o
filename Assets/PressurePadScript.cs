using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePadScript : MonoBehaviour
{
    public void onEnter()
    {
        //AkSoundEngine.PostEvent("Play_SFX_PressurePad_Activate", gameObject);
        AkSoundEngine.PostEvent("Play_LargeDoor", gameObject);
    }

}
