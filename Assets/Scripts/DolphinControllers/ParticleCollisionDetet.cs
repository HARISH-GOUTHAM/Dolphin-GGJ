using System;
using UnityEngine;

namespace DefaultNamespace.DolphinControllers
{
    public class ParticleCollisionDetet : MonoBehaviour
    {
        private void OnParticleCollision(GameObject other)
        {
            if (other.GetComponent<WaterHittable>() != null)
            {
                other.GetComponent<WaterHittable>().OnHitByWater();
            }
        }
    }
}