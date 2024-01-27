using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParachuteFollow : MonoBehaviour
{
    [SerializeField] private Transform jetski;
    [SerializeField] private float recordDelay = .5f;

    private Queue<Vector3> recordedPositions;

    private Vector3 currentTarget;
    // Start is called before the first frame update
    void Start()
    {
        currentTarget = transform.position;
        recordedPositions = new Queue<Vector3>(10);
        InvokeRepeating(nameof(Playback),recordDelay * 10,recordDelay);
        InvokeRepeating(nameof(Record),recordDelay,recordDelay);
        
    }

    // Update is called once per frame
    void Update()
    {
        //move towards current target within 1 second using leantween
        
        
        
    }

    public void Record()
    {
        recordedPositions.Enqueue(jetski.position);
        
    }

    private LTDescr tween;
    public void Playback()
    {
        Vector3 target = recordedPositions.Dequeue();
        currentTarget = new Vector3(target.x,transform.position.y,target.z);
        if(tween!=null)
        LeanTween.cancel(tween.id);
        tween = LeanTween.move(gameObject,currentTarget,1f);
    }
    
    
}
