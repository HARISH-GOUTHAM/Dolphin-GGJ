using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class DolphinMovement : MonoBehaviour, DolphinInputs.IDolphinMovementActions
{
    private DolphinInputs _dolphinInputs;
    private WaterCallbacks _waterCallbacks;

    private Rigidbody rb;

    [SerializeField] private float accelerationInput;
    [SerializeField] private float decelerationInput;
    [SerializeField] private Vector2 stearInput;
    [SerializeField] private bool canDash;
    [SerializeField]private bool isUnderWater;



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
        move();
    }

    private void move()
    {
        rb.AddForce(transform.forward*accelerationInput * playerStats.acclerationForce,ForceMode.Acceleration);
        transform.Rotate(new Vector3(stearInput.y * playerStats.turnSpeed, stearInput.x*playerStats.turnSpeed,0));

    }

    private void OnwaterEnter()
    {
        isUnderWater = true;
    }
    private void OnwaterExit()
    {
        isUnderWater = false;
    }

    public void OnAccelerate(InputAction.CallbackContext context)
    {
        accelerationInput=context.ReadValue<float>();
    }

    public void OnReverse(InputAction.CallbackContext context)
    {
        Debug.Log("accee");
    }

    public void OnSteerLeftRight(InputAction.CallbackContext context)
    {
        Debug.Log("fe");
    }

    public void OnSteerUpDown(InputAction.CallbackContext context)
    {
        Debug.Log("fefd");
    }

    public void OnDash(InputAction.CallbackContext context)
    {
        if (context.started)
            Debug.Log("dash");
    }

   

    public void OnSteer(InputAction.CallbackContext context)
    {
        stearInput=context.ReadValue<Vector2>();
    }
}
[Serializable]
public class PlayerStats
{
    public float acclerationForce;
    public float decclerationForce;
    public float turnSpeed;
    public float dashForce;

    public AudioClip dolphinLaugh;



}
