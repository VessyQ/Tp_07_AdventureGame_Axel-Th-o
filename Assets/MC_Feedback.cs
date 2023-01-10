using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_Feedback : MonoBehaviour
{
    [Header("Wwise Audio")]

    public AK.Wwise.Event hitEvent;
    public AK.Wwise.Event deathEvent;
    public AK.Wwise.Event respawnEvent;

    public GameObject ellenEmitter;


    private void onHit(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            hitEvent.Post(ellenEmitter);
        }
    }

    private void onDeath(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            deathEvent.Post(ellenEmitter);
        }
    }

    private void onRespawn(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            respawnEvent.Post(ellenEmitter);
        }
    }

}
