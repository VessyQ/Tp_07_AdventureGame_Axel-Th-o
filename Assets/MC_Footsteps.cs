using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MC_Footsteps : MonoBehaviour


{
    [Header("Wwise AUdio")]
    public AK.Wwise.Event footstepEvent;
    public AK.Wwise.Event jumpEvent;
    public AK.Wwise.Event landtepEvent;

    public GameObject leftFootEmitter;
    public GameObject rightFootEmitter;


    private void OnFootstepLeft(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            footstepEvent.Post(leftFootEmitter);
        }
    }

    private void OnFootstepRight(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            footstepEvent.Post(rightFootEmitter);
        }
    }
}
