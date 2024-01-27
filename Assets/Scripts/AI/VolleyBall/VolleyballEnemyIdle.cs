using System.Collections;
using System.Collections.Generic;
using AI;
using UnityEngine;

public class VolleyballEnemyIdle : EnemyBehaviour
{
    public GameObject volleyball;
    
    
    public override void PerformBehaviour()
    {
        SwitchCaseCondition();
    }

    public override void OnBehaviourEnd()
    {
        
    }

    public override void OnBehaviourStart()
    {
        
    }
    
    void SwitchCaseCondition()
    {
        if(Vector3.Distance(volleyball.transform.position, transform.position) > 5)
        {
            SwitchState();
        }
        
    }
}
