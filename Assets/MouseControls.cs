using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControls : MonoBehaviour
{
    //This Script controls the mouse actions in the scene

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Transform ObjTransform = GameObject.FindWithTag("MouseRaycast").GetComponent<MouseRaycast>().SendRaycast();
            string ObjTag = ObjTransform.tag;

            if (ObjTag == "Stove")
            {
                //ObjTransform.getComponent<Stove>().;
                GameObject.FindWithTag("SelectFoodMenu").GetComponent<OpenWindow>().isShow = true;
            }
        }
    }
}
