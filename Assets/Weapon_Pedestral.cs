using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Pedestral : MonoBehaviour
{
    public void onEnter()
    {
        AkSoundEngine.PostEvent("Stop_SFX_Pedestral_Idle", gameObject);
        AkSoundEngine.PostEvent("Play_SFX_UI_MM_PlayButton", gameObject);
    }

}
