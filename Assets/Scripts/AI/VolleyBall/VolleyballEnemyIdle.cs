using System.Collections;
using System.Collections.Generic;
using AI;
using UnityEngine;

public class VolleyballEnemyIdle : EnemyBehaviour
{
    public GameObject volleyball;
    
    [SerializeField] private Animator _animator;
    [SerializeField]private string idleAnimationStateName = "Idle";

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public override void PerformBehaviour()
    {
        SwitchCaseCondition();
    }

    public override void OnBehaviourEnd()
    {
        
    }

    public override void OnBehaviourStart()
    {
        _animator.Play(idleAnimationStateName);
    }
    
    void SwitchCaseCondition()
    {
        if(Vector3.Distance(volleyball.transform.position, transform.position) > 5)
        {
            SwitchState();
        }
        
    }
}
