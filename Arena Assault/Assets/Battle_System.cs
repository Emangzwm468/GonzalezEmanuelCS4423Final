using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { Start, PlayerAction, PlayerMove, EnemyMove, Busy}

public class Battle_System : MonoBehaviour
{
    //[SerializeField]
    //[SerializeField] BattleHud playerHud;
    [SerializeField] DialougeBox dialougeBox;

    BattleState state;
    int currentAction;
    int currMove;

    private void Start()
    {
        StartCoroutine(BattleSetup());
    }
    public IEnumerator BattleSetup()
    {
        PlayerAction();
        yield return null;
    }

    void PlayerAction()
    {
        state = BattleState.Start;
        dialougeBox.EnableActionSelection(true);
    }

    IEnumerator PerformPlayerMove()
    {
        state = BattleState.Busy;
        var move = currentAction;
        yield return null;

        // bool isDead = enemyUnit.Challengers.TakeDamage(attacks, playerUnit.Challenger);

        /*if (isDead)
         * {
         *    yield return dialogBox.TypeDialog($"(enemyUnit.Challengers.EnemyHandler.challengerName) had been defeated!");
         * }
         * else
         * {
         *     StartCourtine(EnemyMove());
         * }
         */
    }

    IEnumerator EnemyMove()
    {
        state = BattleState.EnemyMove;

        var move = enemyUnit.Challengers.GetRandomAttacks();

        // bool isDead = enemyUnit.Challengers.TakeDamage(attacks, playerUnit.Challengers);

        /*if (isDead)
         * {
         *    yield return dialogBox.TypeDialog($"(playerUnit.Challengers.EnemyHandler.challengerName) has been defeatd!");
         * }
         * else
         * {
         *     PlayerAction();
         * }
         */
    }

    private void Update()
    {
        if (state == BattleState.PlayerAction)
        {
            HandleActionSelection();
        }
        else if (state == BattleState.PlayerMove)
        {
            HandleMoveSelection();
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
        dialougeBox.UpdateActionSelection(currentAction);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(currentAction == 0)
            {
                PlayerAction();
            }
            else if (currentAction == 1)
            {
                //Surrender
            }
        }
    }

    void HandleMoveSelection()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currMove < PlayerUnit.Challengers.Attacks.Count - 1)
                ++currMove;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentAction > 0)
                --currentAction;
        }

        dialougeBox.UpdateMoveSelection(currMove);

        if (Input.GetKeyDown(KeyCode.Z))
        {
            dialougeBox.EnabledMoveSelector(false);
            dialougeBox.EnabledDialogText(true);
            StartCoroutine(PerformPlayerMove());
        }
    }
}
