using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ColorSelect : MonoBehaviour
{
    public GameObject model;
    public GameObject garm1;
    public GameObject garm2;
    private bool active;

    Color[] classicColors = new Color[]{new Color(144, 20, 20), new Color(146, 146, 146), new Color(0, 0, 0), new Color(11, 18, 65), new Color(101, 105, 133)};
    Color[] trendyColors = new Color[]{new Color(203, 216, 70), new Color(178, 155, 204), new Color(49, 27, 9), new Color(162, 162, 162)};
    Color[] edgyColors = new Color[]{new Color(0, 0, 0), new Color(76, 76, 76), new Color(51, 10, 93), new Color(180, 255, 0)};
    Color[] relaxedColors = new Color[]{new Color(101, 105, 133), new Color(135, 134, 134), new Color(196, 194, 194), new Color(204, 208, 242) };
    Color[] preppyColors = new Color[]{new Color(172, 193, 228), new Color(238, 197, 211), new Color(247, 231, 215), new Color(31, 28, 67) };
    Color[] chicColors = new Color[]{new Color(48, 26, 8), new Color(180, 149, 119), new Color(123, 93, 63), new Color(255, 243, 232)};
    Color[] funkyColors = new Color[]{new Color(183, 111, 52), new Color(159, 186, 93), new Color(164, 140, 110), new Color(239, 224, 98)};
    Color[] streetColors = new Color[] { new Color(0, 0, 0), new Color(48, 26, 8), new Color(135, 134, 134), new Color(47, 72, 44), new Color(137, 209, 132) };

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (model.activeSelf) {
            active = true;
        }
    }

    public Color randomColor(Color[] options) {
        System.Random rnd = new System.Random();
        int colorIndex = rnd.Next(options.Length);
        return options[colorIndex];
        
    }

    void colorGenerate() {
        //if statements to determine style 
        garm1.GetComponent<MeshRenderer>().material.color = randomColor(funkyColors);

    }
}
