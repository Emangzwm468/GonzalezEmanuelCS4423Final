using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUnit : MonoBehaviour
{
    [SerializeField] EnemyHandler Challenger;
    [SerializeField] bool isPUnit;

    public Challengers Challengers { get; set; }

    public void Setup()
    {
        Challengers = new Challengers(Challenger);
        if (isPUnit)
            GetComponent<Image>().sprite = Challengers.Challenger.FSprite;
        else
            GetComponent<Image>().sprite = Challengers.Challenger.FSprite;
    }

}
