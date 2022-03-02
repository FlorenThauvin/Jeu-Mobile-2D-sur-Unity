using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarreDeVie : MonoBehaviour{
    public Slider slider;
    public Gradient grad;
    public Image img;

    public void SetMaxHealth(int vie){
        slider.maxValue = vie;
        slider.value = vie;

        img.color = grad.Evaluate(1f);
    }

    public void SetHealth( int vie){
        slider.value = vie;
        img.color = grad.Evaluate(slider.normalizedValue);
    }
}
