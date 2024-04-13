using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Attacks", menuName = "Unit/Create new attacks")]
public class AttacksHandler : ScriptableObject
{
    [SerializeField] string Attack_Name;

    [TextArea]
    [SerializeField] string Attack_Description;
    [SerializeField] int Attack_Power;
}
