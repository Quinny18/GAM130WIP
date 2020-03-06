using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePointRotate : MonoBehaviour
{

    public Camera cam;
    public Transform firePointRotate;
    Vector2 mousePos;

    public static float radius = 1f;
    public Transform pivot;

    void Start()
    {
        pivot = firePointRotate.transform;
        transform.parent = pivot;
        transform.position += Vector3.up * radius;
    }

    void FixedUpdate()
    {
        Vector3 fpVector = Camera.main.WorldToScreenPoint(firePointRotate.position);
        fpVector = Input.mousePosition - fpVector;
        float angle = Mathf.Atan2(fpVector.y, fpVector.x) * Mathf.Rad2Deg;

        pivot.position = firePointRotate.position;
        pivot.rotation = Quaternion.AngleAxis(angle -65f, Vector3.forward);
    }
}
