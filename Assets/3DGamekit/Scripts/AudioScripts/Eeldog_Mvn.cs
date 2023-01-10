using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eeldog_Mvn : MonoBehaviour
{

    [Header("Wwise Audio")]

    public AK.Wwise.Event Out_Water;
    public AK.Wwise.Event In_Water;

    public GameObject Eeldog;
    private void Out(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            Out_Water.Post(Eeldog);
        }
    }

    private void In(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            In_Water.Post(Eeldog);
        }
    }

}

