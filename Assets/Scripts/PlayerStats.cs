using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Possibilities
{
    public class PlayerStats : MonoBehaviour
    {
        [Header("Player Stats")]
        public float PlayerExperience = 0f;
        public float PlayerHealth = 100f;
        public int PlayerLevel = 1;

        [Header("Attributes")]
        public List<PlayerAttributes> Attributes = new List<PlayerAttributes>();

        [Header("Skills")]
        public List<Skills> PlayerSkills = new List<Skills>();

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
