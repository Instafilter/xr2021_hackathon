﻿using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Architecture
{
    [CreateAssetMenu(
        menuName = "Create Step",
        fileName = "Step",
        order = 120)]
    public class Step : ScriptableObject
    {
        [SerializeField] private StepFeature[] _features;

        public bool ContainsFeature(StepFeature feature) => _features.Contains(feature);

        [ShowIf("@ContainsFeature(StepFeature.ModularMenu)")] [SerializeField]
        private ModularMenuData _modularMenuData;
        
        [ShowIf("@ContainsFeature(StepFeature.DialogMenu)")] [SerializeField]
        private DialogMenuData _dialogMenuData;
        [ShowIf("@ContainsFeature(StepFeature.VoiceActing)")] [SerializeField]
        private VoiceActingData _voiceActingData;
        [ShowIf("@ContainsFeature(StepFeature.DeviceAction)")] [SerializeField]
        private DeviceActionData _deviceActionData;
     

        public ModularMenuData MenuData => _modularMenuData;

        public DialogMenuData DialogMenuData => _dialogMenuData;

        public VoiceActingData ActingData => _voiceActingData;
    }
    
    public class DeviceActionData
    {
    }
}