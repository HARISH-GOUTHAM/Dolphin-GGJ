using UnityEngine;
using UnityEngine.Events;

namespace AI
{
    public abstract class EnemyBehaviour :MonoBehaviour
    {
        public UnityEvent OnBehaviourStartEv;
        public UnityEvent OnBehaviourEndEv;
        
        public abstract void PerformBehaviour();
        public abstract void OnBehaviourEnd();
        public abstract void OnBehaviourStart();
        
        public void SwitchState()
        {
            OnBehaviourEnd();
            OnBehaviourEndEv.Invoke();
        }
    }
}