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

       
        swimAway = true;

    }
  
    public void EntersWater()
    {
    }



    public void SecondaryInteract()
    {
        
    }

    public void StopInteract()
    {
        
    }
    private void Update()
    {
       
    }

    // Start is called before the first frame update



}
