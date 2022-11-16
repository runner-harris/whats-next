using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    protected bool rotate = false;

    public void CubeRotate () {
        rotate = !rotate;
    }

    public void Update() {
        if(rotate)
        {
            transform.Rotate (new Vector3 (0, 0, -45) * Time.deltaTime);
        }
    }
}
