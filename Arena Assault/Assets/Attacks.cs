using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks
{
    public AttacksHandler AttacksHandler { get; set; }
 
    public Attacks(AttacksHandler attacksHandler)
    {
        AttacksHandler = attacksHandler;
    }
}
