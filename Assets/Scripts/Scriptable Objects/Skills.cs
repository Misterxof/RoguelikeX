using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Possibilities
{
    [CreateAssetMenu(menuName = "Generator/Player/Create Skill")]
    public class Skills : ScriptableObject
    {
        public string Name;
        public string Descriptiton;
        public Sprite Icon;
        public int KnowledgePointsNeeded;
        public int CurrentLevel;
        public bool isEvolutionary;
        public List<PlayerAttributes> AffectetedAttributes = new List<PlayerAttributes>();

        public void OnRequirements() { }

        public void OnPowers() { }
    }
}
