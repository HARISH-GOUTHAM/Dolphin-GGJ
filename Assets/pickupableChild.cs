using Abstracts;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class pickupableChild : MonoBehaviour,IInteractable
{
    private Rigidbody rb;

    public bool swimAway;

    public float speed;

    public Transform target;
    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void PrimaryInteract(Transform parent = null)
    {
        if (parent != null)
        {
            rb.useGravity = false;
            transform.position = parent.position;
            transform.SetParent(parent);
            return;
        }
    }
  
    public void EntersWater()
    {
    }



    public void SecondaryInteract()
    {
        
    }

    public void StopInteract()
    {
        transform.parent = null;
        rb.useGravity = true;
        rb.isKinematic = false;
        swimAway = true;
    }
    private void Update()
    {
        if (!swimAway) return;
        Vector3 dir = target.position - transform.position;
        dir = dir.normalized;
        dir*=speed;
        transform.Translate(dir);
    }

    // Start is called before the first frame update



}
