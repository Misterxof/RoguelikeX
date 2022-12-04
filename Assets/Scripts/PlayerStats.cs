using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Possibilities
{
    public class PlayerStats : MonoBehaviour
    {
        [Header("Player Stats")]
        
        public float PlayerHealth = 100f;

        [SerializeField]
        private float m_PlayerExperience = 0;

        public float PlayerExperience
        {
            get { return m_PlayerExperience; }
            set {
                m_PlayerExperience = value;

                if (onExperienceChange != null)
                    onExperienceChange();
            }
        }

        [SerializeField]
        private int m_Level = 1;
        public int PlayerLevel
        {
            get { return m_Level; }
            set
            {
                m_Level = value;

                //  for subscribers
                if (onLevelChange != null)
                    onLevelChange();
            }
        }
        public int PlayerKnowledgePoints = 1;

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

        //  Delegates for listeners
        public delegate void OnExperienceChange();
        public event OnExperienceChange onExperienceChange;

        public delegate void OnLevelChange();
        public event OnLevelChange onLevelChange;

        // test
        public void UpdateLevel(int amount)
        {
            PlayerLevel += amount;
        }

        public void UpdateKP(int amount)
        {
            PlayerKnowledgePoints += amount;
        }
    }
}
