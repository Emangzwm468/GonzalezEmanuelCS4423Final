using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum StateofBattle {BEGIN, PLAYERTURN, ENEMYTURN, WIN, LOST }

public class BattleHandler : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    //Unit playerCharacter;
    //Unit enemyCharacter;

    public StateofBattle state;
    // Start is called before the first frame update
    void Start()
    {
        state = StateofBattle.BEGIN;
        BattleSetup();
    }

    public void BattleSetup()
    {
         Instantiate(playerPrefab);
        //playerCharacter = playerSTART.GetComponent<Unit>();
         Instantiate(enemyPrefab);
        //enemyCharacter = enemySTART.GetComponent<Unit>();
    }

}
