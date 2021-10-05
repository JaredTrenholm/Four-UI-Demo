using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Camera cam;
    void Update()
    {
        this.gameObject.transform.rotation = new Quaternion(cam.transform.rotation.x, cam.transform.rotation.y, cam.transform.rotation.z, cam.transform.rotation.w);
    }
}
