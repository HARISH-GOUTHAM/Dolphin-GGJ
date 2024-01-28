using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowChild : MonoBehaviour
{
    public GameObject child;
    public float speed;
    private Vector3 dir;
    public bool lostchild;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!lostchild) return;
        dir= child.transform.position-transform.position;
        dir= dir.normalized;
        dir*=speed * Time.deltaTime;
        transform.LookAt(child.transform);
        transform.Translate(dir);

        
    }
}
