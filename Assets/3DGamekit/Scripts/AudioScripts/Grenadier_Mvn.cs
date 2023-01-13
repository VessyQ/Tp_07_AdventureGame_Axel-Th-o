using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenadier_Mvn : MonoBehaviour
{
    [Header("Wwise Audio")]

    public AK.Wwise.Event Footsteps;
    public AK.Wwise.Event Hit;
    public AK.Wwise.Event Canon;
    public AK.Wwise.Event Punch;
    public AK.Wwise.Event Zone;
    public AK.Wwise.Event Death;
    public AK.Wwise.Event Iddle;

    public GameObject Chomper;

    private void Golem_Footsteps(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
           Footsteps.Post(Chomper);
        }
    }

    private void Golem_Hit(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            Hit.Post(Chomper);
        }
    }

    private void Gollem_attack_canon(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
           Canon.Post(Chomper);
        }
    }

    private void Gollem_attack_punch(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            Punch.Post(Chomper);
        }
    }
    private void Gollem_attack_zone(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            Zone.Post(Chomper);
        }
    }
    private void Gollem_idle(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            Iddle.Post(Chomper);
        }
    }
    private void Gollem_Death(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            Death.Post(Chomper);
        }
    }
}