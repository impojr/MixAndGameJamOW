using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AttackType
{
    Slash,
    Thrust
}

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject sword;
    public AttackType attackType;

    void Update()
    {
        ProcessAttack();
    }

    private void ProcessAttack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            attackType = AttackType.Slash;
            Attack("Attack");
        } else if (Input.GetButtonDown("Fire2"))
        {
            attackType = AttackType.Thrust;
            Attack("Thrust");
        }
    }

    private void Attack(string animationName)
    {
        sword.SetActive(true);
        sword.GetComponent<Animator>().Play(animationName);
    }
}
