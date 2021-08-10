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

        // 画面中心を軸に回転させる
        this.transform.RotateAround (
            center,
            Vector3.forward,
            dAngle * Time.deltaTime
        );
    }
}