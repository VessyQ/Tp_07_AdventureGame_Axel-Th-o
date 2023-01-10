using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enm_Chomper : MonoBehaviour
{
    [Header("Wwise Audio")]

    public AK.Wwise.Event attack;
    public AK.Wwise.Event FrontStep;
    public AK.Wwise.Event BackStep;
    public AK.Wwise.Event Hit;
    public AK.Wwise.Event Grunt;
    public AK.Wwise.Event Death;
    public AK.Wwise.Event Spotted;

    public GameObject Chomper;

    private void Chomper_Attack(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            attack.Post(Chomper);
        }
    }

    private void Chomper_Frontstep(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            FrontStep.Post(Chomper);
        }
    }

    private void Chomper_BackStep(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            BackStep.Post(Chomper);
        }
    }

    private void Chomper_Hit(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            Hit.Post(Chomper);
        }
    }
    private void Chomper_Grunt(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            Grunt.Post(Chomper);
        }
    }
    private void Chomper_Death(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            Death.Post(Chomper);
        }
    }
    private void Chomper_Spotted(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            Spotted.Post(Chomper);
        }
    }
}