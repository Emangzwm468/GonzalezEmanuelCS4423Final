using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
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
}
