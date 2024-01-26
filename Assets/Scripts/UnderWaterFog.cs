using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class UnderWaterFog : MonoBehaviour
{
    
    [SerializeField] private Color underwaterFog;
    [SerializeField] private float fogDensity = .05f;
    
    private BoxCollider fogBounds;
    private Color defaultFog; 
    private float defaultDensity;
    // Start is called before the first frame update
    void Start()
    {
        fogBounds = GetComponent<BoxCollider>();
        defaultFog = RenderSettings.fogColor;
        defaultDensity = RenderSettings.fogDensity;
    }

    // Update is called once per frame
    void Update()
    {
      
       
        //check if camera is in the saaame x and z position as the fog bounds
        if(Camera.main.transform.position.x > fogBounds.bounds.min.x && Camera.main.transform.position.x < fogBounds.bounds.max.x && Camera.main.transform.position.z > fogBounds.bounds.min.z && Camera.main.transform.position.z < fogBounds.bounds.max.z)
        {
            if(Camera.main.transform.position.y < fogBounds.bounds.max.y)
            {
                RenderSettings.fogColor = underwaterFog;
                RenderSettings.fogDensity = fogDensity;
                return;
            }
            else
            {
                
        
                RenderSettings.fogColor = defaultFog;
                RenderSettings.fogDensity = defaultDensity;
            }
        }
    }
}
