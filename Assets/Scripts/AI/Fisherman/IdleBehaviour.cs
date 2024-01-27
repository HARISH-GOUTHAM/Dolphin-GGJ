using System.Collections;
using System.Collections.Generic;
using AI;
using AI.Fisherman;
using DefaultNamespace;
using UnityEngine;

public class IdleBehaviour : EnemyBehaviour
{

    public FishingRod rod;
    [SerializeField] private CameraTransition _transition;
    
    public override void PerformBehaviour()
    {
        if (Vector3.Distance(rod.transform.position, rod.lineStart.position)>30)
        {
            _transition.StartTransition();
            SwitchState();
        }
    }

    public override void OnBehaviourEnd()
    {
        
    }

    public override void OnBehaviourStart()
    {
    }
}
