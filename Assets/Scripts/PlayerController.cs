using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Components
    Rigidbody2D _rigidbody;
    [SerializeField] FixedJoystick _joystick;
    private HealthBar healthBar;
    private ExperienceBar experienceBar;

    // Player
    public ObjectType type = ObjectType.Player;
    public float healthPoints = 100f;
    public float experiencePoints = 0f;
    public float walkSpeed = 2f;
    public float speedLimiter = 0.7f;
    float inputHorizontal;
    float inputVertitcal;

    // Start is called before the first frame update 
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        healthBar = new HealthBar(healthPoints);
        experienceBar = new ExperienceBar(experiencePoints);
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
        healthBar.OnHealthtChange(healthPoints);
    }

    public void OnExperienceChange(float experience)
    {
        experiencePoints += experience;
        experienceBar.OnExperienceChange(experiencePoints);
    }
}
