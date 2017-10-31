using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Otros NS
using UnityEngine.UI;

public class ControlCombustible : MonoBehaviour {

    float incremento = 10;
    Slider sliderCombustible;

    public static bool hayCombustible = true;

	void Start () {

        // Asignando el slider
        sliderCombustible = GetComponent<Slider>();
    }
    
    void Update () {

        // Añadir combustible
        if (Input.GetKeyDown(KeyCode.A))
        {
            sliderCombustible.value += incremento;
            hayCombustible = true;
        }
        // Consumir combustible
        if (Input.GetKeyDown(KeyCode.D))
        {
            sliderCombustible.value -= incremento;
        }
        // Comprobar si queda combustible
        if (sliderCombustible.value <= 0)
        {
            hayCombustible = false;
        }

    }
}
