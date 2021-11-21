﻿using System;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Architecture
{
    [Serializable]
    public class ModularMenuData
    {
        public string _mainText;

        [ShowIf("@ContainsFeature(ModularMenuFeature.Image)")]
        public Sprite _sprite;

        [ShowIf("@ContainsFeature(ModularMenuFeature.Image)")]
        public string _imageText;

        [ShowIf("@ContainsFeature(ModularMenuFeature.Title)")]
        public string _titleText;
        
        public ModularMenuFeature[] _features = Array.Empty<ModularMenuFeature>();

        private bool ContainsFeature(ModularMenuFeature feature) => _features.Contains(feature);
    }
}