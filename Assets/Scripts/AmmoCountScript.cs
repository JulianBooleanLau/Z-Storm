using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Edit UI text

public class AmmoCountScript : MonoBehaviour
{

    public static int currAmmo = 2;
    public static int maxAmmo = 12;
    public Text ammoCounter;

    // Start is called before the first frame update
    void Start()
    {
        ammoCounter = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ammoCounter.text = "Ammo: " + currAmmo + "/" + maxAmmo;
    }
}
