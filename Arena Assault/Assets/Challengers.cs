using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Challengers
{
    EnemyHandler _challengers { get; set; }

    public int HP { get; set; }

    public List<Attacks> Attacks { get; set; }

    public Challengers(EnemyHandler pChallenger)
    {
        _challengers = pChallenger;
        HP = _challengers.MaxHealth;

        /*Attacks = new List<Attacks>();
        foreach (var attack in _challengers.Attacks)
        {
            if (attack.Count >= 4)
                break;
        }*/
    }

    public int Attack 
    {  
        get { return Mathf.FloorToInt(5 + 1);} 
    }

    public int Spd
    {
        get { return Mathf.FloorToInt(1 + 1); }
    }

    public int MaxHealth
    {
        get { return Mathf.FloorToInt(5 + 1); }
    }

    public int Health
    {
        get { return _challengers.Health; }
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
