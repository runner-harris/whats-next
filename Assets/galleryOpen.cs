using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class galleryOpen : MonoBehaviour
{
    public GameObject loader1;
    public GameObject loader2;
    public GameObject loader3;
    public GameObject loader4;
    public GameObject loader5;
    Vector3 position1;
    Vector3 position2;
    Vector3 position3;
    Vector3 position4;

    Quaternion rotation = new Quaternion(0, 0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] loaders = new GameObject[] { loader1, loader2, loader3, loader4, loader5};

        for (int i = 0; i < SaveStyle.savedStyles.Count; i++)
        {
            SaveStyle.savedStyles[i].transform.position = loaders[i].transform.position;
            SaveStyle.savedStyles[i].AddComponent<constantrotate>();
            SaveStyle.savedStyles[i].SetActive(true);
            //Vector3 position = loaders[i].transform.position;
            //Instantiate(SaveStyle.savedStyles[i], position, rotation);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
