using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TimeController : MonoBehaviour
{
    public UnityEvent loseCondition;
    
    [SerializeField] private int min, seg;
    [SerializeField] private Text tiempo;

    private float restante;
    private bool enMarchaEstoy;

    private void Awake()
    {
        restante = (min + 60) + seg;
        enMarchaEstoy = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (enMarchaEstoy)
        {
            restante -= Time.deltaTime;
            if (restante <= 0)
            {
                restante = 0;
                enMarchaEstoy = false;
                //SALE UI DE PERDER
            }

            int tempMin = (int)restante / 60;
            int tempSeg = (int)restante % 60;
            tiempo.text = tempMin.ToString("00") + ":" + tempSeg.ToString("00");
        }
        
    }
}
