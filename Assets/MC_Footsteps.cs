using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class MC_Footsteps : MonoBehaviour
{
    [SerializeField]
    private AK.Wwise.Event footstepsEvent;
    private void PlayFootstepsSound()
    {
        footstepsEvent.Post(gameObject);
    }
    
    [SerializeField]
    private AK.Wwise.Switch footstepsRock;
    [SerializeField]
    private AK.Wwise.Switch footstepsGrass;

    [SerializeField]
    private AK.Wwise.Event LandEvent;
    [SerializeField]
    private AK.Wwise.Switch LandRock;
    [SerializeField]
    private AK.Wwise.Switch LandGrass;

 
   
    [Header("Wwise Audio")]
  // public AK.Wwise.Event footstepEvent;
    public AK.Wwise.Event jumpEvent;
  //  public AK.Wwise.Event landEvent;

   //public AK.Wwise.Switch MySwitch;

    public GameObject leftFootEmitter;
    public GameObject rightFootEmitter;


    /*private void OnFootstepLeft(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            GroudSwitchFootsteps();
            AkSoundEngine.SetSwitch("Play_Footstep_Switch", "Grass", gameObject);
            footstepEvent.Post(leftFootEmitter);
        }
    }

   private void OnFootstepRight(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            GroudSwitchFootsteps();
            AkSoundEngine.SetSwitch("Play_Footstep_Switch", "Grass", gameObject);
            footstepEvent.Post(rightFootEmitter);
        }
    }
    private void OnLandAnim(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            GroudSwitchLand();
            AkSoundEngine.SetSwitch("MC_Land_Switch", "Grass", gameObject);
            landEvent.Post(leftFootEmitter);
        }
    }*/


    private void OnJumpAnim(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            //MySwitch.SetValue(leftFootEmitter);
            jumpEvent.Post(leftFootEmitter);
        }
    }


    private void GroudSwitchFootsteps(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            //MySwitch.SetValue(leftFootEmitter);
            footstepsEvent.Post(leftFootEmitter);
        
        
        RaycastHit hit;
        Ray ray = new Ray(transform.position + Vector3.up * 0.5f, -Vector3.up);
        Material surfaceMaterial;



        if (Physics.Raycast(ray, out hit, 1.0f, Physics.AllLayers, QueryTriggerInteraction.Ignore))
        {
            Renderer surfaceRenderer = hit.collider.GetComponentInChildren<Renderer>();
                if (surfaceRenderer)
                {
                    if (surfaceRenderer.material.name.Contains("Floor"))
                    {
                        //AkSoundEngine.SetSwitch("Play_Footstep_Switch", "SW_Rock");
                        footstepsRock.SetValue(gameObject);
                    }
                    else
                    {
                        //AkSoundEngine.SetSwitch("Play_Footstep_Switch", "SW_Grass");
                        footstepsGrass.SetValue(gameObject);
                    }
                }

 }           
        }
    }
    private void GroudSwitchLand(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            //MySwitch.SetValue(leftFootEmitter);
            LandEvent.Post(leftFootEmitter);

            RaycastHit hit;
            Ray ray = new Ray(transform.position + Vector3.up * 0.5f, -Vector3.up);
            Material surfaceMaterial;

            if (Physics.Raycast(ray, out hit, 1.0f, Physics.AllLayers, QueryTriggerInteraction.Ignore))
            {
                Renderer surfaceRenderer = hit.collider.GetComponentInChildren<Renderer>();
                if (surfaceRenderer)
                {
                    if (surfaceRenderer.material.name.Contains("Floor"))
                    {
                        //AkSoundEngine.SetSwitch("MC_Land_Switch", "SW_Rock");
                        LandRock.SetValue(gameObject);
                    }
                    else
                    {
                        // AkSoundEngine.SetSwitch("MC_Land_Switch", "SW_Grass");
                        LandGrass.SetValue(gameObject);
                    }

                }
            }

        }
    }


}
