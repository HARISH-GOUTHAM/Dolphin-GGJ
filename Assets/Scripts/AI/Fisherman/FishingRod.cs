using System;
using Abstracts;
using Unity.Collections;
using UnityEngine;

namespace AI.Fisherman
{
    public class FishingRod : MonoBehaviour,IInteractable
    {

        private LineRenderer _renderer;
        public Transform hook; 
        

        private void Start()
        {
            _renderer = GetComponent<LineRenderer>();
        }

        public void PrimaryInteract(Transform parent = null)
        {
            hook.SetParent(parent);
            hook.localPosition = Vector3.zero;
            
            
        }

        public void SecondaryInteract()
        {
            
        }

        private void Update()
        {
            _renderer.SetPositions(new []{
                transform.position,
                hook.position
            });
        }
    }
}