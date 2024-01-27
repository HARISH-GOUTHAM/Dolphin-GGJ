using System.Collections;
using System.Collections.Generic;
using AI;
using AI.Fisherman;
using UnityEngine;

public class IdleBehaviour : EnemyBehaviour
{
    private string idleAnimationStateName = "Idle";
    [SerializeField]private Animator _animator;

    private FishingRod rod;
    
    public override void PerformBehaviour()
    {
        if (Vector3.Distance(rod.transform.position, transform.position)>10)
        {
            SwitchState();
        }
    }

    public override void OnBehaviourEnd()
    {
        
    }

    public override void OnBehaviourStart()
    {
        _animator.Play(idleAnimationStateName);
    }
}
