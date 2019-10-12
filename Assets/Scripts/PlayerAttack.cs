using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject sword;

    void Update()
    {
        ProcessAttack();
    }

    private void ProcessAttack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            sword.SetActive(true);
        }
    }
}
