using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlayerUnit : MonoBehaviour
{
    [SerializeField] Challengers challengers;
    [SerializeField] bool isPUnit;

    public Challengers Challengers { get; set; }

    public void Setup()
    {
        /*challengers = new Challengers(Challenger);
        if (isPUnit)
            GetComponent<Image>().sprite = ;
        else
            GetComponent<Image>().sprite = challengers;*/
    }

}
