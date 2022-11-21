using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{

    protected bool rotate = false;

    public void CubeRotate () {
        rotate = !rotate;
    }

    public void Update() {
        if(rotate)
        {
            transform.Rotate (new Vector3 (0, 0, 45) * Time.deltaTime);
        }
    }
    
}
