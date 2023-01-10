using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_ComboHit : MonoBehaviour
{
    [Header("Wwise Audio")]
    public AK.Wwise.Event comboOne;
    public AK.Wwise.Event comboTwo;
    public AK.Wwise.Event comboThree;
    public AK.Wwise.Event comboFour;

    public GameObject staffWeapon;


    private void OnFirstCombo(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            comboOne.Post(staffWeapon);
        }
    }

    private void OnSecondCombo(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            comboTwo.Post(staffWeapon);
        }
    }

    private void OnThirdCombo(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            comboThree.Post(staffWeapon);
        }
    }

    private void OnFourthCombo(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            comboFour.Post(staffWeapon);
        }
    }



}
