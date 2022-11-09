using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{

    // Update is called once per frame
    void rotate()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
}
