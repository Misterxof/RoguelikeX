using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceBar : MonoBehaviour
{
    private const float MAX_EXPERIENCE = 100f;

    private Image experiencneBar;

    public ExperienceBar(float experience)
    {
        experiencneBar = GameObject.FindWithTag("ExperienceBar").GetComponent<Image>();
        OnExperienceChange(experience);
    }

    public void OnExperienceChange(float experience)
    {
        experiencneBar.fillAmount = experience / MAX_EXPERIENCE;
    }
}
