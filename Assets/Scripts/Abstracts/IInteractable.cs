using System.Net.Http.Headers;
using UnityEngine;

namespace Abstracts
{
    public interface IInteractable
    {
        
        
        public void PrimaryInteract(Transform parent = null);

        public void StopInteract();
        
        public void SecondaryInteract();
    }
}