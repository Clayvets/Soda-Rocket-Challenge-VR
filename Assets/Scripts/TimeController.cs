using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class TimeController : MonoBehaviour
{
    public UnityEvent loseCondition;
    
    [SerializeField] private int min, seg;
    [SerializeField] private int min2, seg2;
    [SerializeField] private Text tiempo;
    [SerializeField] private Text tiempo2;

    private float restante;
    private float restante2;
    private bool enMarchaEstoy;

    private void Awake()
    {
        restante = (min * 60) + seg;
        restante2 = (min2 * 60) + seg2;
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
                loseCondition.Invoke();
                //SALE UI DE PERDER
            }

            int tempMin = (int)restante / 60;
            int tempSeg = (int)restante % 60;
            tiempo.text = tempMin.ToString("00") + ":" + tempSeg.ToString("00");
        }else
        {
            restante2 -= Time.deltaTime;
            int tempMin2 = (int)restante2 / 60;
            int tempSeg2 = (int)restante2 % 60;
            tiempo2.text = tempMin2.ToString("00") + ":" + tempSeg2.ToString("00");
            if (restante2 <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
        
    }
}
