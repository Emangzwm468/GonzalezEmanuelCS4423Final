using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks
{
    public AttacksHandler Attacks_Handler { get; set; }
 
    public Attacks(AttacksHandler pAttacks)
    {
        Attacks_Handler = pAttacks;
    }
}
