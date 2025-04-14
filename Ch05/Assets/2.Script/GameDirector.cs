using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject hpGauge; 
    void Start()
    {
        //hpGauge = GameObject.Find("HP Gauge");
    }

    
    void Update()
    {
        
    }

    public void DecreaseHP()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
