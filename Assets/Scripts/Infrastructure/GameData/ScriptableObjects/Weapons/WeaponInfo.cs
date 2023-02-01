using UnityEngine;

namespace Infrastructure.GameData.ScriptableObjects.Weapons
{
    [CreateAssetMenu(fileName = "New Weapon Info", menuName = "Weapon Data")]
    public class WeaponInfo : ScriptableObject
    {
        [SerializeField] private string weaponName;
        [SerializeField] private string description;
        [SerializeField] private Sprite icon;
        [SerializeField] private float damage;
        [SerializeField] private float cooldown;

        public string WeaponName => weaponName;
        public string Description => description;
        public Sprite Icon => icon;
        public float Damage => damage;
        public float Cooldown => cooldown;
    }
}