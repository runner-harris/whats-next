using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveStyle : object
{
    // Start is called before the first frame update
    public static List<GameObject> savedStyles = new List<GameObject>();

    public static void addStyle(GameObject style) {
        savedStyles.Add(style);
    }

}
