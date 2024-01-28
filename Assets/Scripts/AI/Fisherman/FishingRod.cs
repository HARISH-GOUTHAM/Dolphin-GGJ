using System;
using Abstracts;
using Unity.Collections;
using UnityEngine;

namespace AI.Fisherman
{
    public class FishingRod : MonoBehaviour,IInteractable
    {

        private LineRenderer _renderer;
        public Transform lineStart; 
        

        private void Start()
        {
            _renderer = GetComponent<LineRenderer>();
        }

        public void PrimaryInteract(Transform parent = null)
        {
            transform.SetParent(parent);
            transform.localPosition = Vector3.zero;
        }

        public void SecondaryInteract()
        {
            
        }

        private void Update()
        {
            _renderer.SetPositions(new []{
                transform.position,
                lineStart.position
            });
        }

        public void StopInteract()
        {
            transform.SetParent(null);
        }
    }
}