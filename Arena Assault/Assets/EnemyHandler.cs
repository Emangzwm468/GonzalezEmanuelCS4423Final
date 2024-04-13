using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Challenger", menuName = "Enemy/Create new enemy")]
public class EnemyHandler : ScriptableObject
{
    [SerializeField] string challengerName;
    [SerializeField] Sprite fSprite;


    //Enemy Stats
    [SerializeField] int Maxhealth;
    [SerializeField] int attack;
    [SerializeField] int spd;
}

public enum Attacktype
{
    Poison,
    Fire,
    Electric

}
