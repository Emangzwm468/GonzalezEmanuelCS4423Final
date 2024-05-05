using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarManager : MonoBehaviour
{
    [SerializeField] GameObject health;

    public void HPSet(float healthNormalized)
    {
       health.transform.localScale = new Vector3(healthNormalized, 1f);
    }
}
