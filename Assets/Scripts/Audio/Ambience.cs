using UnityEngine;

namespace DefaultNamespace.Audio
{
    [RequireComponent(typeof(WaterCallbacks))]
    public class Ambience : MonoBehaviour
    {
        private WaterCallbacks _waterCallbacks;
        [SerializeField]private AudioSource overWater;
        [SerializeField]private AudioSource underWater;
        
        private void Start()
        {
            _waterCallbacks = GetComponent<WaterCallbacks>();
            
            _waterCallbacks.OnWaterEnter.AddListener(OnWaterEnter);
            _waterCallbacks.OnWaterExit.AddListener(OnWaterExit);
        }

        private void OnWaterExit()
        {
            underWater.volume = 0;
            overWater.volume = 1;
        }

        private void OnWaterEnter()
        {
            underWater.volume = 1;
            overWater.volume = .2f;
        }

         
    }
}