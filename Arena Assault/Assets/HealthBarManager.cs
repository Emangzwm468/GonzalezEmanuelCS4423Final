using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarManager : MonoBehaviour
{
    public Transform foregroundTransform;

    [Range(0f,1f)]
    public float percentage = 1f;

    // Update is called once per frame
    void Update()
    {
        foregroundTransform.localScale = new Vector3(percentage, 1f, 1f);

    }
}
