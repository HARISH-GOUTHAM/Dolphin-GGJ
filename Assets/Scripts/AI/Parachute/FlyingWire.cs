using System;
using Abstracts;
using UnityEngine;

namespace AI.Parachute
{
    public class FlyingWire : MonoBehaviour,IInteractable
    {

        public bool isCut = false;
        private LineRenderer _renderer;
        
        public Transform lineEnd;
        public void PrimaryInteract(Transform parent = null)
        {
            isCut = true;
        }

        public void SecondaryInteract()
        {
            
        }
        
        private void Start()
        {
            _renderer = GetComponent<LineRenderer>();
        }

        private void Update()
        {
            _renderer.SetPositions(new []{
                transform.position,
                lineEnd.position
            });
        }

        public void StopInteract()
        {
            
        }
    }
}