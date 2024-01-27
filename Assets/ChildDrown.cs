using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildDrown : EnemyBehaviour
{
    public GameObject father;
    public Animator parentAnimator;
    public string swimingAnimation = "Swimming";
    public float stolenAnimationTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        parentAnimator = father.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void OnBehaviourEnd()
    {
        throw new System.NotImplementedException();
    }

    public override void OnBehaviourStart()
    {
        parentAnimator.Play(swimingAnimation);
        father.GetComponent<FollowChild>().lostchild = true;
        
    }

    public override void PerformBehaviour()
    {

    }
    
}
