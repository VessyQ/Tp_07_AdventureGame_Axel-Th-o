using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MC_Footsteps : MonoBehaviour


{
    [Header("Wwise Audio")]
    public AK.Wwise.Event footstepEvent;
    public AK.Wwise.Event jumpEvent;
    public AK.Wwise.Event landEvent;

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

    private void OnJumpAnim(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            jumpEvent.Post(leftFootEmitter);
        }
    }

    private void OnLandAnim(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            landEvent.Post(leftFootEmitter);
        }
    }

}
