using System.Collections;
using System.Collections.Generic;
using AI;
using AI.Parachute;
using UnityEngine;

public class ParachuteGuyIdle : EnemyBehaviour
{
    
    public FlyingWire wire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void PerformBehaviour()
    {
        if(wire.isCut)
            SwitchState();
    }

    public override void OnBehaviourEnd()
    {
        
    }

    public override void OnBehaviourStart()
    {
        
    }
}
