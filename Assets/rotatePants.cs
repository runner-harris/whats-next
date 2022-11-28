using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePants : MonoBehaviour
{

    protected bool rotate = false;

    public void CubeRotate () {
        rotate = !rotate;
    }

    public void Update() {
        if(rotate)
        {
            transform.Rotate (new Vector3 (0, 45, 0) * Time.deltaTime);
        }
    }
    
}

