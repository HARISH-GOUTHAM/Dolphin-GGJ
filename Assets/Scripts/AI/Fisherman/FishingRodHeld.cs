using UnityEngine;

namespace AI.Fisherman
{
    public class FishingRodHeld : EnemyBehaviour
    {

        [SerializeField]private Animator _animator;
        
        public override void PerformBehaviour()
        {
            
        }

        public override void OnBehaviourEnd()
        {
            
        }

        public override void OnBehaviourStart()
        {
            _animator.SetBool("isHolding",true);
            Invoke(nameof(resetAnim),1f);
            
        }

        void resetAnim()
        {
            
            _animator.SetBool("isHolding",false);
        }
    }
}