using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class CameraTransition : MonoBehaviour
    {
        [SerializeField]private Camera cam;
        [SerializeField]private Transform camTransform;
        [SerializeField] private Canvas c;
        public float delay = 5f;
        public float transitionTime = 1f;
        private void Start()
        {
            
        }

        private void Update()
        {
            
        }

        public void StartTransition()
        {
            c.gameObject.SetActive(true);
            cam.transform.position = camTransform.position;
            cam.transform.rotation = camTransform.rotation;
            
            Invoke(nameof(Resetcam),delay);

        }

        public void Resetcam()
        {

            c.gameObject.SetActive(false);
        }
    }
}