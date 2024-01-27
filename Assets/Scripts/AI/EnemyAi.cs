using System;
using System.Collections;
using System.Collections.Generic;
using AI;
using UnityEngine;

public enum EnemyState
{
    Idle,
    Annoyed
}

[Serializable]
struct EnemyStateData
{
    public EnemyState state;
    public EnemyBehaviour behaviour;
}

public class EnemyAi : MonoBehaviour
{
    private EnemyState _currentState;
    private int _currentBehaviourIndex = 0;
    
    [SerializeField] private List<EnemyStateData> _behaviours;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (var i in _behaviours)
        {
            i.behaviour.OnBehaviourEndEv.AddListener(SwitchState);
        }

        _currentState = _behaviours[_currentBehaviourIndex].state;
    }

    // Update is called once per frame
    void Update()
    {
        _behaviours[_currentBehaviourIndex].behaviour.PerformBehaviour();
    }

    public void SwitchState()
    {
        _currentBehaviourIndex++;
        if (_currentBehaviourIndex >= _behaviours.Count)
        {
            _currentBehaviourIndex = 0;
        }
        _currentState = _behaviours[_currentBehaviourIndex].state;
        _behaviours[_currentBehaviourIndex].behaviour.OnBehaviourStart();

    }
    public void SwitchState(EnemyState state)
    {
        _currentState = state;
        _behaviours[_currentBehaviourIndex].behaviour.OnBehaviourStart();
    }
}
