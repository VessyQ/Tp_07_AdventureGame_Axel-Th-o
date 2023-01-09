using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class UiButtonSound : MonoBehaviour
{

    public void onClick()
    {
        AkSoundEngine.PostEvent("Play_SFX_UI_MM_PlayButton", gameObject);
    }
    

    public void pointerEnter()
    {
        AkSoundEngine.PostEvent("Play_SFX_UI_MM_Navigate", gameObject);
    }

}
