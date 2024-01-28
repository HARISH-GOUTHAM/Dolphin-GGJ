using System;
using UnityEngine;

namespace AI.Castle
{
    public class Castle : MonoBehaviour,WaterHittable
    {
        public bool isDestroyed = false;
        
        public void OnHitByWater()
        {
            isDestroyed = true; 
        }
    }
}