using System.Collections;
using System.Collections.Generic;
using AI;
using AI.Parachute;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.Serialization;

public class ParachuteGuyflewAway : EnemyBehaviour
{
    public FlyingWire wire;
     public Animator flyingGuyAnim;
     public Animator jetSkiAnim;
     public CameraTransition transition;
    public override void PerformBehaviour()
    {
        
    }

    public override void OnBehaviourEnd()
    {
        
    }

    public override void OnBehaviourStart()
    {
        flyingGuyAnim.SetBool("flewAway",true);
        jetSkiAnim.SetBool("flewAway",true);
        transition.StartTransition();
    }
}
