using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]

public class Ww_MaterialSwitch : MonoBehaviour
{
    public string SwitchGroupe = "Play_Footstep_Switch";
    public string Switch = "Grass";
    public string ExitSwitch = "Rock";
    public GameObject Character;
    public bool Debug_Enable;

    private void OntriggerEnter(Collider other)
    {
        if (Debug_Enable) { Debug.Log(Switch + "switch set"); }
        AkSoundEngine.SetSwitch(SwitchGroupe, Switch, Character);
    }

    private void OnTriggerExit(Collider other)
    {
        if (Debug_Enable) { Debug.Log(ExitSwitch + "switch set"); }
        AkSoundEngine.SetSwitch(SwitchGroupe, ExitSwitch, Character);
    }
}
