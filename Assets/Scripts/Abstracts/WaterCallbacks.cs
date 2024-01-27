using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaterCallbacks : MonoBehaviour
{
    
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
       if(isUnderWater && transform.position.y > GerstnerWaveDisplacement.instance.GetWaveDisplacement(transform.position))
       {
           isUnderWater = false;
           OnWaterExit.Invoke();
       }
       else if(!isUnderWater && transform.position.y < GerstnerWaveDisplacement.instance.GetWaveDisplacement(transform.position))
       {
           isUnderWater = true;
           OnWaterEnter.Invoke();
       }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(new Vector3(transform.position.x, GerstnerWaveDisplacement.instance.GetWaveDisplacement(transform.position), transform.position.z), 0.5f);
    }
}
