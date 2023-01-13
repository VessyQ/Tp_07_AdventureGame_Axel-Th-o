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

    //public AK.Wwise.Switch MySwitch;

    public GameObject leftFootEmitter;
    public GameObject rightFootEmitter;


    private void OnFootstepLeft(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            //MySwitch.SetValue(leftFootEmitter);
            footstepEvent.Post(leftFootEmitter);
        }
    }

    private void OnFootstepRight(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            //MySwitch.SetValue(rightFootEmitter);
            footstepEvent.Post(rightFootEmitter);
        }
    }

    private void OnJumpAnim(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            //MySwitch.SetValue(leftFootEmitter);
            jumpEvent.Post(leftFootEmitter);
        }
    }

    private void OnLandAnim(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            //MySwitch.SetValue(leftFootEmitter);
            landEvent.Post(leftFootEmitter);
        }
    }

}
