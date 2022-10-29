using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRaycast : MonoBehaviour
{
    //This script send a mouse raycast and return what object and your properties that mouse is hover
    public Camera cam;

    public Transform SendRaycast()
    {
        Transform objectHit = null;

        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            objectHit = hit.transform;
        }

        return objectHit;
    }
}
