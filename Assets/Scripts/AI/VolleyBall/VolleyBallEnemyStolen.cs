using System.Collections;
using System.Collections.Generic;
using AI;
using UnityEngine;

public class VolleyBallEnemyStolen : EnemyBehaviour
{
    public Animator animator;
    public string stolenAnimationStateName = "Stolen";
    public float stolenAnimationTime = 1.0f;
    
    public string beachIdleAnimationStateName = "BeachIdle";
    

    public override void PerformBehaviour()
    {
        
    }

    public override void OnBehaviourEnd()
    {
       
    }

    public override void OnBehaviourStart()
    {
       animator.Play(stolenAnimationStateName);
       Invoke(nameof(PlayAnimation), stolenAnimationTime);
         
    }
    
    void PlayAnimation()
    {
        animator.Play(beachIdleAnimationStateName);
    }
}
