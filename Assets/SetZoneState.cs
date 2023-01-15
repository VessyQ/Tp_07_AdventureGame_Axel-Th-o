using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class SetZoneState : MonoBehaviour
{
    public AK.Wwise.State OnTriggerEnterState;
    public AK.Wwise.State OnTriggerExitState;

    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    if (hit.collider == null)
    //    {
    //        return;
    //    }
    //    if (hit.collider.tag == "state")
    //    {
    //        OnTriggerEnterState.SetValue();
    //        print("rentré");
    //    }
    //    else
    //    {
    //        OnTriggerExitState.SetValue();
    //        print("sortie");
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ellen"))
        {
            OnTriggerEnterState.SetValue();
            print("rentré");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ellen"))
        {
            OnTriggerExitState.SetValue();
            print("sortie");
        }
    }
}
