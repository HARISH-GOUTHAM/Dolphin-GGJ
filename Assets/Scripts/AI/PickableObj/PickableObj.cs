using Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObj : MonoBehaviour,IInteractable
{
    public void PrimaryInteract(Transform parent = null)
    {
        if (parent != null)
        {
            transform.position = parent.position;
            transform.SetParent(parent);
            return;
        }
    }

    public void SecondaryInteract()
    {
        throw new System.NotImplementedException();
    }
}
