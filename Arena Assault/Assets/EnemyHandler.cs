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
}

public class Moves
{
    [SerializeField] AttacksHandler attackHandler;
}

public enum Attacktype
{
    Poison,
    Fire,
    Electric

}
