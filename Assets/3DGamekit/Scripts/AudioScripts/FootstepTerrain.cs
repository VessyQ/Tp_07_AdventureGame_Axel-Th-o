using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FootstepCollectionEntry
{
    public string textureName;

    public AK.Wwise.Switch footstepCollection;
}

public class FootstepTerrain : MonoBehaviour
{
    public List<FootstepCollectionEntry> collections;

    public GameObject leftFootEmitter;
    public GameObject rightFootEmitter;

    private AK.Wwise.Switch currentCollection;
    private TerrainCheckData terrainCheck;
    private string currentLayer;
    // Start is called before the first frame update
    void Start()
    {
        terrainCheck = new TerrainCheckData();
    }

    private void Update()
    {
        CheckLayers();
    }

    public void CheckLayers()
    {
        //raycast down
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.5f))
        {
            if (hit.transform.GetComponent<Terrain>() != null)
            {
                Terrain t = hit.transform.GetComponent<Terrain>();
                if (currentLayer != terrainCheck.GetLayerName(transform.position, t))
                {
                    currentLayer = terrainCheck.GetLayerName(transform.position, t);
                    currentCollection = null;
                    foreach (FootstepCollectionEntry fc in collections)
                    {
                        if (currentLayer == fc.textureName)
                        {
                            currentCollection = fc.footstepCollection;
                            fc.footstepCollection.SetValue(leftFootEmitter);
                            fc.footstepCollection.SetValue(rightFootEmitter);
                            break;
                        }
                    }
                }
            }
            else if (currentLayer != LayerMask.LayerToName(hit.transform.gameObject.layer))
            {
                currentLayer = LayerMask.LayerToName(hit.transform.gameObject.layer);
                currentCollection = null;
                foreach (FootstepCollectionEntry fc in collections)
                {
                    if (currentLayer == fc.textureName)
                    {
                        currentCollection = fc.footstepCollection;
                        fc.footstepCollection.SetValue(leftFootEmitter);
                        fc.footstepCollection.SetValue(rightFootEmitter);
                        break;
                    }
                }
            }

        }
    }
    //public string TerrainLayer_00, TerrainLayer_01, TerrainLayer_02; 


    /*
    private List<AudioClip> GetDefaultSound()
    {
        List<AudioClip> defaultList = new List<AudioClip>();
        defaultList.Add(defaultSound);
        return defaultList;
       
    }
    public List<AudioClip> GetWalkFootsteps()
    {
        CheckLayers();
        if (currentCollection != null)
        {
            return currentCollection.walkClips;
        }
        return GetDefaultSound();
    }
    public List<AudioClip> GetRunFootsteps()
    {
        CheckLayers();
        if (currentCollection != null)
            return currentCollection.runClips;
        return GetDefaultSound();
    }
    public AudioClip GetJumpFootstep()
    {
        CheckLayers();
        if (currentCollection != null)
            return currentCollection.jumpClip;
        return defaultSound;
    }
    public AudioClip GetLandFootstep()
    {
        CheckLayers();
        if (currentCollection != null)
            return currentCollection.landClip;
        return defaultSound;
    }
    private void PlayFootstepsAudio()
    {
        // if (!m_PlayerArmature.isGrouded)
        // {
        //      return;
        //  }
        AkSoundEngine.PostEvent("Walk", gameObject);
        AkSoundEngine.PostEvent("Run", gameObject);
        AkSoundEngine.PostEvent("Jump", gameObject);
        AkSoundEngine.PostEvent("Land", gameObject);

       // ak.soundengine.SetSwitch("Groud_Material",,gameObject);
    }
    */
   
}
    