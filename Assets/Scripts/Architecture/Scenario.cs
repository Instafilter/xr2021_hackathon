using System;
using ScriptableSystem.GameEvent;
using UnityEngine;

namespace Architecture
{
    [CreateAssetMenu(
        menuName = "Create Scenario", 
        fileName = "Scenario", 
        order = 120)]
    public class Scenario : ScriptableObject
    {
        [SerializeField] private StepGameEvent _onStepLoaded;
        [SerializeField] private GameEvent _onStepChanged;
        [SerializeField] private Step[] _steps;
        [SerializeField] private GameEvent _onStepEnded;


        private int _currentStepNumber;


        private void Awake()
        {
            _currentStepNumber = 0;
        }


        private void OnEnable()
        {
            _onStepEnded.AddAction(LoadNextStep);
        }

        private void OnDisable()
        {
            _onStepEnded.RemoveAction(LoadNextStep);
        }

        private void LoadNextStep() => 
            _currentStepNumber = (_currentStepNumber + 1) % _steps.Length;


    }
}