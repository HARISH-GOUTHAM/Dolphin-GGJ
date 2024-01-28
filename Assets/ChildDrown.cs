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
        parentAnimator.Play(swimingAnimation);
        father.GetComponent<FollowChild>().lostchild = true;
        
    }

    public override void PerformBehaviour()
    {
        Vector3 c = (target.position - child.transform.position).normalized * childSpeed * Time.deltaTime;
        child.transform.position += new Vector3(c.x,child.transform.position.y,c.z);
    }
    
}
