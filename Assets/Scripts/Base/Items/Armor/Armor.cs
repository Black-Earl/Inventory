using UnityEngine;
using Items.Armor.ArmorTypes;

namespace Items.Armor
{
    /// <summary>
    /// Armor
    /// </summary>
    [CreateAssetMenu(fileName = "New Armor",menuName = "Inventory/Create Armor")]
    public class Armor: Item
    {
        [SerializeField] private ArmorTypes.ArmorTypes _types;

        public ArmorTypes.ArmorTypes Types => _types;
    }
}