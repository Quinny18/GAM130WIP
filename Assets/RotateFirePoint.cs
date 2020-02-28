using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFirePoint : MonoBehaviour
{

    public Camera cam;
    public Rigidbody2D rotateFirePointrb;
    Vector2 mousePos;

    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = mousePos - rotateFirePointrb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rotateFirePointrb.rotation = angle;
    }
}
