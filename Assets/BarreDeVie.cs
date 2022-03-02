using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarreDeVie : MonoBehaviour{
    public Slider slider;
    public Gradient grad;
    public Image img;

    public void SetMaxHealth(int vie){
        slider.maxValue = vie;          // on lui met tous ses HP
        slider.value = vie;

        img.color = grad.Evaluate(1f); // dégradé de couleur pour la barre de vie
    }

    public void SetHealth( int vie){
        slider.value = vie;
        img.color = grad.Evaluate(slider.normalizedValue);      // on normalise pour avoir le dégradé entre 0 et 1
    }
}
