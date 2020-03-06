using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackOnMouse : MonoBehaviour
{
    public GameObject attackPrefab;
    public GameObject rangeAttackPrefab;
    public Transform firePoint;
    public Vector2 target;
    public Rigidbody2D rb;
    
    public float boltForce = 20f;

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            rangedAttack();
        }
    }
    void Attack()
    {
        GameObject attackObj = Instantiate(attackPrefab, firePoint.position, firePoint.rotation);
        Destroy(attackObj, 1.0f);
    }

    void rangedAttack()
    {
        GameObject attackObj = Instantiate(rangeAttackPrefab, firePoint.position, firePoint.rotation);
        Destroy(attackObj, 1.0f);
    }



}
