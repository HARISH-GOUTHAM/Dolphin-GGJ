using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaterCallbacks : MonoBehaviour
{
    public static float waterLevel = 10f;
    
    public UnityEvent OnWaterEnter;
    public UnityEvent OnWaterExit;
    
    public bool isUnderWater = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(isUnderWater && transform.position.y > waterLevel)
       {
           isUnderWater = false;
           OnWaterExit.Invoke();
       }
       else if(!isUnderWater && transform.position.y < waterLevel)
       {
           isUnderWater = true;
           OnWaterEnter.Invoke();
       }
    }
}
