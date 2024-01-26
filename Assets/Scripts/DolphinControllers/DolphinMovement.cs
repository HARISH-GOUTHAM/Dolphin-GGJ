using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DolphinMovement : MonoBehaviour,DolphinInputs.IDolphinMovementActions
{
    private DolphinInputs _dolphinInputs;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAccelerate(InputAction.CallbackContext context)
    {
        
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

    public void OnCamera(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}
