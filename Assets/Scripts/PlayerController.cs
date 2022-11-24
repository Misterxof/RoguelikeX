using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Components
    Rigidbody2D _rigidbody;
    [SerializeField] FixedJoystick _joystick;

    // Player
    public ObjectType type = ObjectType.Player;
    public float healthPoints = 100f;
    public float walkSpeed = 2f;
    public float speedLimiter = 0.7f;
    float inputHorizontal;
    float inputVertitcal;

    // Start is called before the first frame update 
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = _joystick.Horizontal;
        inputVertitcal = _joystick.Vertical;

        if (healthPoints <= 0)
        {
            Debug.Log("DEAD");
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
            Debug.Log(inputHorizontal);

            _rigidbody.velocity = new Vector2(inputHorizontal * walkSpeed, inputVertitcal * walkSpeed);
        } else
        {
            _rigidbody.velocity = Vector2.zero;
        }
    }

    public void OnHealthDamage(float damage)
    {
        healthPoints -= damage;
    }
}
