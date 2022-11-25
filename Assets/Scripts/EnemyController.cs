using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Components
    Rigidbody2D rigidbody;
    GameObject player;
    Rigidbody2D playerRigidBody;

    // Enemy
    public ObjectType type = ObjectType.Enemy;
    public float healthPoints = 100f;
    public float damage = 10f;
    public float walkSpeed = 2f;
    public float speedLimiter = 0.7f;
    float inputHorizontal;
    float inputVertitcal;

    // Start is called before the first frame update 
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
        playerRigidBody = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directitonX = rigidbody.position.x - playerRigidBody.position.x;
        float directitonY = rigidbody.position.y - playerRigidBody.position.y;

        if (directitonX > 0 && directitonY > 0)
        {
            inputHorizontal = -1f;
            inputVertitcal = -1f;
        } else if (directitonX < 0 && directitonY < 0)
        {
            inputHorizontal = 1f;
            inputVertitcal = 1f;
        } else if (directitonX > 0 && directitonY < 0)
        {
            inputHorizontal = -1f;
            inputVertitcal = 1f;
        }
        else if (directitonX < 0 && directitonY > 0)
        {
            inputHorizontal = 1f;
            inputVertitcal = -1f;
        }

    }

    private void FixedUpdate()
    {
        if (inputHorizontal != 0 || inputVertitcal != 0)
        {
            if (inputHorizontal != 0 && inputVertitcal != 0)
            {
                inputHorizontal *= speedLimiter;
                inputVertitcal *= speedLimiter;
            }

            rigidbody.velocity = new Vector2(inputHorizontal * walkSpeed, inputVertitcal * walkSpeed);
        }
        else
        {
            rigidbody.velocity = Vector2.zero;
        }
    }

    public void OnCollisionWithPlayer(Collider2D collision, GameObject impacter)
    {
        impacter.GetComponent<PlayerController>().OnHealthDamage(10);
        Debug.Log("Health " + impacter.GetComponent<PlayerController>().healthPoints);
    }
}