using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class CameraTransition : MonoBehaviour
    {
        [SerializeField]private Camera cam;
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
            cam.gameObject.SetActive(true);
            LeanTween.value(1, .5f, transitionTime).setOnUpdate((float val) =>
            {
                Camera.main.rect = new Rect(1, 1, val, 1);
            });
            Invoke(nameof(Resetcam),delay);

        }

        public void Resetcam()
        {

            cam.enabled = false;
            LeanTween.value(Camera.main.rect.width, 1f, 0.5f).setOnUpdate((float val) =>
            {
                Camera.main.rect = new Rect(1, 1, val, 1);
            });
        }
    }
}