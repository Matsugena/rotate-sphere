using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSphere : MonoBehaviour {
    [SerializeField]
    Vector3 center = Vector3.zero;
    [SerializeField]
    float dAngle = 50f;

    public void Rotate () {
        if (center == null) return;

        // Rotate around the center of (0,0,0)
        this.transform.RotateAround (
            center,
            Vector3.forward,
            dAngle * Time.deltaTime
        );
    }
}