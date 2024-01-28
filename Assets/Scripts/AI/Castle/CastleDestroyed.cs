using DefaultNamespace;
using UnityEngine;

namespace AI.Castle
{
    public class CastleDestroyed : EnemyBehaviour
    {
        [SerializeField] private Animator castleAnim;
        [SerializeField] private CameraTransition transition;
        public override void PerformBehaviour()
        {
            
        }

        public override void OnBehaviourEnd()
        {
            
        }

        public override void OnBehaviourStart()
        {
            castleAnim.SetBool("destroyed",true);
            transition.StartTransition();
            DolphinLaugh.instance.PlayLaugh();
        }
    }
}