using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUIScript : MonoBehaviour
{
    public Slider slider;
    public Text text;

    public void changeMaxHealth(int amount)
    {
        slider.maxValue = amount;
        slider.value = amount;
    }
    public void setHealth(int amount)
    {
        slider.value = amount;
    }
    public void adaptLives(int amount)
    {
        text.text = "Lives: " + amount;
    }
}
