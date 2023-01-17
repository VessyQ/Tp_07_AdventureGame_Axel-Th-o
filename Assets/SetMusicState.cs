using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMusicState : MonoBehaviour
{

    public AK.Wwise.State OnTriggerEnterState;
    public AK.Wwise.State OnTriggerExitState;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ellen"))
        {
            OnTriggerEnterState.SetValue();
            print("rentré fight");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ellen"))
        {
            OnTriggerExitState.SetValue();
            print("sortie fight");
        }
    }
}
