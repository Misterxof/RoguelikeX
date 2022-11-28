using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public LayerMask enemyLayers;

    public float attackRange = 0.5f;
    public float damage = 50f;

    public float attackRate = 2f;
    float nextAttackTime = 0f;


    // Update is called once per frame
    void Update()
    {
        animator = gameObject.GetComponent<Animator>();
        attackPoint = GameObject.Find("/Player/AttackPoint").transform;
    }

    public void AttackButtonOnCLick()
    {
        if (Time.time >= nextAttackTime)
        {
            Attack();
            nextAttackTime = Time.time + 1f / attackRate;
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hittedEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hittedEnemies)
        {
            enemy.GetComponent<EnemyController>().OnHealthDamage(damage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint != null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
