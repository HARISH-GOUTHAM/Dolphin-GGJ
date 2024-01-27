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
    WaterCallbacks waterCallbacks;
    // Start is called before the first frame update
    void Start()
    {
        fogBounds = GetComponent<BoxCollider>();
        defaultFog = RenderSettings.fogColor;
        defaultDensity = RenderSettings.fogDensity;
        waterCallbacks = GetComponent<WaterCallbacks>();
        waterCallbacks.OnWaterEnter.AddListener(OnWaterEnter);
        waterCallbacks.OnWaterExit.AddListener(OnWaterExit);
    }

    // Update is called once per frame
    void Update()
    {
      
       
       
    }
    
    private void OnWaterEnter()
    {
        RenderSettings.fogColor = underwaterFog;
        RenderSettings.fogDensity = fogDensity;
    }
    private void OnWaterExit()
    {
        RenderSettings.fogColor = defaultFog;
        RenderSettings.fogDensity = defaultDensity;
    }
    
}
