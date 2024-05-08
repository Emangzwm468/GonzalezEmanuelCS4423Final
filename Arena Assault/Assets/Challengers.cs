using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Challengers
{
    public EnemyHandler challengers { get; set; }

    public int HP { get; set; }

    public Challengers(EnemyHandler pChallenger)
    {
        challengers = pChallenger;
        HP = MaxHealth;
    }

    public int Attack 
    {  
        get { return challengers.Attack;} 
    }

    public int Spd
    {
        get { return challengers.Spd; }
    }

    public int MaxHealth
    {
        get { return challengers.MaxHealth; }
    }

    public int Health
    {
        get { return challengers.Health; }
    }

    public bool DamageTaken(Attacks attack, Challengers attacker)
    {
        int damage;

        float modifiers = UnityEngine.Random.Range(0.05f, 1f);

        damage = Mathf.FloorToInt(modifiers);

        HP -= damage;
        if (HP < 0)
        {
            HP = 0;
            return true;
        }

        return false;
    }

    /*public Attacks GetRandomAttacks()
    {
        int i;

        i = UnityEngine.Random.Range(0, Attacks.Count);
        return Attacks[i];
    }*/
}
