using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUnit : MonoBehaviour
{
    [SerializeField] EnemyHandler _challengers;
    [SerializeField] bool isPUnit;

    public Challengers Challengers { get; set; }

    public void Setup()
    {
        Challengers = new Challengers(_challengers);
        if (isPUnit)
            GetComponent<Image>().sprite = Challengers.Challenger.FSprite;
        else
            GetComponent<Image>().sprite = Challengers.Challenger.FSprite;
    }

}
