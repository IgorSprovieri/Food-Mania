using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindow : MonoBehaviour
{
    //This script open and hide a window in a scene
    public GameObject Object;
    Vector3 Target;
    public bool isShow;
    void Update()
    {
        if(isShow == true)
        {
            Target = new Vector3(1, 1, 1);
        }
        else
        {
            Target = new Vector3(0, 0, 0);
        }

        Object.transform.localScale = Vector3.Lerp(Object.transform.localScale, Target, 5.0f * Time.deltaTime);
    }
}
