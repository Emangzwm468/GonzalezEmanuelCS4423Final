using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { Start, PlayerAction, PlayerMove, EnemyMove, Busy}

public class Battle_System : MonoBehaviour
{
    //[SerializeField]
    //[SerializeField] BattleHud playerHud;

    BattleState state;
    int currentAction;

    private void Start()
    {
        StartCoroutine(BattleSetup());
    }
    public IEnumerator BattleSetup()
    {
        PlayerAction();
    }

    void PlayerAction()
    {
        state = BattleState.Start;
    }

    private void Update()
    {
        if (state == BattleState.PlayerAction)
        {
            HandleActionSelection();
        }
    }

    void HandleActionSelection()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentAction < 1)
                ++currentAction;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentAction > 0)
                --currentAction;
        }
    }
}
