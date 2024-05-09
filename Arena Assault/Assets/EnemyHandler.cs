using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Challenger", menuName = "Enemy/Create new enemy")]
public class EnemyHandler : ScriptableObject
{
    [SerializeField] string challengerName;
    [SerializeField] Sprite fSprite;


    //Enemy/Challenger Stats
    [SerializeField] int Maxhealth;
    [SerializeField] int attack;
    [SerializeField] int spd;

    [SerializeField] int health;
    [SerializeField] List<KnownAttacks> knownAttacks;

    public string ChallengerName
    {
        get { return challengerName; }
    }

    public Sprite FSprite
    {
        get { return fSprite; }
    }

    public int MaxHealth
    {
        get { return Maxhealth; }
    }

    public int Attack
    {
        get { return attack; }
    }

    public int Spd
    {
        get { return spd; }
    }

    public int Health
    {
        get { return health; }
    }

    public List<KnownAttacks> Attacks
    {
        get { return knownAttacks; }
    }

    [System.Serializable]

    public class KnownAttacks
    {
        [SerializeField] AttacksHandler attacks;

        public AttacksHandler knownAttacks
        {
            get { return attacks; }
        }
    }

    public enum Attacktype
    {
        Poison,
        Fire,
        Electric

    }
}
