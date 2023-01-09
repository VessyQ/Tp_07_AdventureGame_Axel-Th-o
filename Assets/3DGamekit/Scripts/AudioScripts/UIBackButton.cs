using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBackButton : MonoBehaviour
{
    public void onClick()
    {
        AkSoundEngine.PostEvent("Play_SFX_UI_MM_Back", gameObject);
    }

    public void pointerEnter()
    {
        AkSoundEngine.PostEvent("Play_SFX_UI_MM_Navigate", gameObject);
    }
}
