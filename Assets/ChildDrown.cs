using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildDrown : EnemyBehaviour
{
    public GameObject father;
    public GameObject child;
    public Transform target;
    public Animator parentAnimator;
    public string swimingAnimation = "Swimming";
    public float stolenAnimationTime = 1.0f;
    public float childSpeed = 1.0f;

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
    }

    public override void OnBehaviourStart()
    {
        DolphinTasks.Instance.Strike(1);
        parentAnimator.Play(swimingAnimation);
        father.GetComponent<FollowChild>().lostchild = true;
        LeanTween.move(child, target.position,
            Vector3.Distance(target.position, child.transform.position) / childSpeed);

    }

    public override void PerformBehaviour()
    {
        
    }
    
}
