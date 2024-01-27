using System;
using System.Collections;
using System.Collections.Generic;
using Abstracts;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.Timeline;

public class DolphinMovement : MonoBehaviour, DolphinInputs.IDolphinMovementActions
{
    private DolphinInputs _dolphinInputs;
    private WaterCallbacks _waterCallbacks;

    private Rigidbody rb;

    [SerializeField] private float accelerationInput;
    [SerializeField] private float decelerationInput;
    [SerializeField] private Vector2 stearInput;
    [SerializeField] private bool canDash;
    [SerializeField] private bool isUnderWater;

    private float lastTimeDashed;
    [Header("Interactable")]
    [SerializeField] private Transform interactPoint;
    [SerializeField] private Vector3 interactBoxSize;
    [SerializeField] private LayerMask interactablelayer;
    private bool isPrimaryInteracting, isSecondaryInteracting;


    [SerializeField] public PlayerStats playerStats;

    private void OnEnable()
    {
        _dolphinInputs = new DolphinInputs();
        _dolphinInputs.Enable();
        _dolphinInputs.DolphinMovement.SetCallbacks(this);
    }

    private void OnDisable()
    {
        _dolphinInputs.DolphinMovement.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        _waterCallbacks = GetComponent<WaterCallbacks>();
        rb = GetComponent<Rigidbody>();
        _waterCallbacks.OnWaterEnter.AddListener(OnwaterEnter);
        _waterCallbacks.OnWaterExit.AddListener(OnwaterExit);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        Move();
        ApplyDownwardsForce();
    }

    private void Move()
    {
        if (!isUnderWater) return;

        rb.AddForce(transform.forward * accelerationInput * playerStats.acclerationForce, ForceMode.Acceleration);
        rb.AddForce(-transform.forward * decelerationInput * playerStats.decclerationForce, ForceMode.Acceleration);
        transform.Rotate(new Vector3(stearInput.y * playerStats.turnSpeed, stearInput.x * playerStats.turnSpeed, 0));

    }

    public void ApplyDownwardsForce()
    {
        if(isUnderWater) return;
        rb.AddForce(Vector3.down*playerStats.DownwardsForce,ForceMode.Force);
    }

    private void Dash()
    {
        if ( lastTimeDashed + playerStats.dashCoolDown <= Time.time&&isUnderWater)
        {
            rb.AddForce(transform.forward * playerStats.dashForce, ForceMode.Impulse);
            lastTimeDashed = Time.time;
        }
    }

    private void OnwaterEnter()
    {
        isUnderWater = true;
        rb.drag = playerStats.waterDrag;
    }
    private void OnwaterExit()
    {
        isUnderWater = false;
        rb.drag = playerStats.airDrag;
    }





    #region Inputss

    


    public void OnSteer(InputAction.CallbackContext context)
    {
        stearInput=context.ReadValue<Vector2>();
    }

    public void OnResetOrientation(InputAction.CallbackContext context)
    {
        //tween the x and z rotation to 0
        LeanTween.rotateX(gameObject, 0, 0.5f);
        LeanTween.rotateZ(gameObject, 0, 0.5f);
        
    }

    public void OnPrimaryInteract(InputAction.CallbackContext context)
    {
        if (isPrimaryInteracting)
        {
            //drop the object
        }
        else
        {
            Collider[] interactables = Physics.OverlapBox(interactPoint.position, interactBoxSize, Quaternion.identity, interactablelayer);
            Collider closestInteractable = null;
            //get the closest interactable
            foreach (var i in interactables)
            {
                if (closestInteractable == null)
                {
                    closestInteractable = i;
                }
                else
                {
                    if (Vector3.Distance(i.transform.position, transform.position) <
                        Vector3.Distance(closestInteractable.transform.position, transform.position))
                    {
                        closestInteractable = i;
                    }
                }
            }
            
            if (closestInteractable != null)
            {
                //pick up the object
            }
            

        }
    }

    public void OnSecondaryInteract(InputAction.CallbackContext context)
    {
        //perform the action depending on the object that is currently held
    }

    public void OnDash(InputAction.CallbackContext context)
    {
        if(context.started)
            Dash();
            
    }
    
    public void OnAccelerate(InputAction.CallbackContext context)
    {
        accelerationInput = context.ReadValue<float>();
    }

    public void OnReverse(InputAction.CallbackContext context)
    {
        decelerationInput = context.ReadValue<float>();
    }


    #endregion
    
    
}
[Serializable]
public class PlayerStats
{
    public float acclerationForce;
    public float decclerationForce;
    public float turnSpeed;
    public float dashForce;
    public int dashCoolDown;

    public float waterDrag;
    public float airDrag;
    public float DownwardsForce;

    public AudioClip dolphinLaugh;



}
