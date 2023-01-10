using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleBox_Break : MonoBehaviour
{

    public void onDeath()
    {
        AkSoundEngine.PostEvent("Play_DestructibleBox", gameObject);
    }
}