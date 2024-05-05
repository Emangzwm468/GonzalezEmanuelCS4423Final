using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challengers
{
    EnemyHandler _challengers;

    public Challengers(EnemyHandler pChanllenger)
    {
        _challengers = pChanllenger;
    }

    public int Attack 
    {  
        get { return _challengers.Attack;} 
    }

    public int Spd
    {
        get { return _challengers.Spd; }
    }

    public int MaxHealth
    {
        get { return _challengers.MaxHealth; }
    }
}
