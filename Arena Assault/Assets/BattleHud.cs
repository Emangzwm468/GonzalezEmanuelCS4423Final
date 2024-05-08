using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHud : MonoBehaviour
{
    [SerializeField] HealthBarManager health;



    public void SetData(Challengers challenger)
    {
        health.HPSet((float)challenger.Health/ challenger.MaxHealth);
    }

    /*public void UpdateHealth()
    {
        
    }*/
}
