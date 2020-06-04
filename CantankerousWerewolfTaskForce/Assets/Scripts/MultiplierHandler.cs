using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MultiplierHandler : MonoBehaviour
{
    public TextMeshProUGUI mutiplier;
    public float startValue = 5.0f;

    private float value;

    private void Start()
    {
        mutiplier.text = startValue.ToString();
        InvokeRepeating("mutlipierSubtraction", 1, 1);
    }
    private void mutlipierSubtraction()
    {
        value = float.Parse(mutiplier.GetComponent<TMPro.TextMeshProUGUI>().text);
        if (value != 1) 
        {
            value -= 0.2f;
        }
        mutiplier.text = value.ToString();
    }
    public void mupltipierReset()
    {
        mutiplier.text = startValue.ToString();
    }
    public void multiplierPause()
    {
        CancelInvoke("mutlipierSubtraction");
    }
}
