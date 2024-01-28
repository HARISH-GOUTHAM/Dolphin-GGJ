using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentChildIdle : EnemyBehaviour
{
    public Animator parentAnimator;
    public string Idle = "Floating";
    public float stolenAnimationTime = 1.0f;
    public GameObject father;
    public GameObject child;

    // Start is called before the first frame update
    void Start()
    {
        parentAnimator = GetComponentInChildren<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void OnBehaviourEnd()
    {
       
    }

    public override void OnBehaviourStart()
    {
        parentAnimator.Play(Idle);
    }

    public override void PerformBehaviour()
    {
        SwitchCaseCondition();
    }

    void SwitchCaseCondition()
    {
        if (Vector3.Distance(father.transform.position, child.transform.position) > 30)
        {
            SwitchState();
        }

    }
}
