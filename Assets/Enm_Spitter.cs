using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enm_Spitter : MonoBehaviour
{
    [Header("Wwise Audio")]

    public AK.Wwise.Event attack;
    public AK.Wwise.Event FrontStep;
    public AK.Wwise.Event BackStep;
    public AK.Wwise.Event Hit;
    public AK.Wwise.Event Grunt;
    public AK.Wwise.Event Death;
    public AK.Wwise.Event Spotted;
    public AK.Wwise.Event Spitt;


    public GameObject Spitter;

    private void Chomper_Attack(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            attack.Post(Spitter);
        }
    }
    private void Spitter_Spitt(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            Spitt.Post(Spitter);
        }
    }

    private void Chomper_Frontstep(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            FrontStep.Post(Spitter);
        }
    }

    private void Chomper_BackStep(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            BackStep.Post(Spitter);
        }
    }

    private void Chomper_Hit(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            Hit.Post(Spitter);
        }
    }
    private void Chomper_Grunt(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            Grunt.Post(Spitter);
        }
    }
    private void Chomper_Death(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            Death.Post(Spitter);
        }
    }
    private void Chomper_Spotted(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            Spotted.Post(Spitter);
        }
    }
}