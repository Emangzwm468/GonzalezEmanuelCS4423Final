using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialougeBox : MonoBehaviour
{
    [SerializeField] Text dialogText;
    [SerializeField] GameObject actionSelector;
    [SerializeField] GameObject moveSelector;

    [SerializeField] Color highlightText;
    [SerializeField] List<TextMeshProUGUI> actionText;

    public void SetDialog(string dialog)
    {
        dialogText.text = dialog;
    }

    public void EnabledDialogText(bool enabled)
    {
        dialogText.enabled = enabled;
    }
    public void EnableActionSelection(bool enabled)
    {
        actionSelector.SetActive(enabled);
    }

    public void EnabledMoveSelector(bool enabled)
    {
        moveSelector.SetActive(enabled);
    }

    public void UpdateActionSelection(int selectedAction)
    {
        for(int i = 0; i < actionText.Count; ++i)
        {
            if (i == selectedAction)
                actionText[i].color = Color.red;
        }
    }

    public void UpdateMoveSelection(int selectedMove)
    {
        for (int i = 0; i < actionText.Count; ++i)
        {
            if (i == selectedMove)
                actionText[i].color = Color.red;
        }
    }
}
