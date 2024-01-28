using UnityEngine;

namespace AI.Castle
{
    public class CastleEnemyIdle : EnemyBehaviour
    {
        [SerializeField] private Castle _castle;
        [SerializeField] private GameObject _destroyedCastle;

        public override void PerformBehaviour()
        {
            if (_castle.isDestroyed)
            {
                _castle.isDestroyed = false;
                _castle.gameObject.SetActive(false);
                _destroyedCastle.SetActive(true);
                SwitchState();
            }   
        }

        public override void OnBehaviourEnd()
        {
            
        }

        public override void OnBehaviourStart()
        {
            
        }
    }
}