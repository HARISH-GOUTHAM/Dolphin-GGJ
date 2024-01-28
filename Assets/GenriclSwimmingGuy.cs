using Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenriclSwimmingGuy : MonoBehaviour,IInteractable,WaterHittable
{

    public GameObject ragdoll;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PrimaryInteract(Transform parent = null)
    {
        SpawnRagDoll();
    }

    public void SecondaryInteract()
    {
        

    }

    public void StopInteract()
    {

    }

    public void OnHitByWater()
    {
        SpawnRagDoll();
    }

    public void SpawnRagDoll()
    {
        Instantiate(ragdoll,transform.position,transform.rotation);
        Destroy(gameObject);
    }
}
