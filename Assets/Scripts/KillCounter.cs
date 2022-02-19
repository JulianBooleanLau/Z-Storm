using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Edit UI text

public class KillCounter : MonoBehaviour
{
    public static int numKills = 0;
    public Text killCounter;

    // Start is called before the first frame update
    void Start()
    {
        killCounter = GetComponent<Text>();
    }

    void Update()
    {
        killCounter.text = "Kills: " + numKills;
    }
}
