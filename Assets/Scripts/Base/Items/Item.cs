using System;
using AttibytesItem;
using UnityEngine;
using System.Collections.Generic;

namespace Items
{
    /// <summary>
    /// Base abstract item element
    /// </summary>
    public abstract class Item : ScriptableObject
    {
        [SerializeField] private string idItem = String.Empty;
        [SerializeField] private string iconPath = String.Empty;
        [SerializeField] private string modelPath = String.Empty;
        [SerializeField] private readonly List<BaseAttributes> allAttributes = new List<BaseAttributes>();

        /// <summary>
        /// Id item
        /// </summary>
        public string IDItem => idItem;

        /// <summary>
        /// Path to icon
        /// </summary>
        public string IconPath => iconPath;

        /// <summary>
        /// Path to Model
        /// </summary>
        public string ModelPath => modelPath;

        /// <summary>
        /// All attributes item
        /// </summary>
        public List<BaseAttributes> AttributesList => allAttributes;
    }
}