using System.Collections;
using System.Collections.Generic;
using AI;
using UnityEngine;

public class IdleBehaviour : EnemyBehaviour
{
    private string idleAnimationStateName = "Idle";
    [SerializeField]private Animator _animator;
    
    
    public override void PerformBehaviour()
    {
       
    }

    public override void OnBehaviourEnd()
    {
        
    }

    public override void OnBehaviourStart()
    {
        _animator.Play(idleAnimationStateName);
    }
}
