using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField]
    GameObject centerOfGame;
    [SerializeField]
    RotateSphere sphere;
    [SerializeField]
    RotateSphere sphereOnGui;
    [SerializeField]
    RotateSphere sphereOnFixedUpdate;

    void Update () {
        sphere.Rotate (); // Inner black sphere
    }

    void FixedUpdate () {
        sphereOnFixedUpdate.Rotate (); // Outer black sphere
    }

    void OnGUI () {
        sphereOnGui.Rotate (); // Yellow sphere
    }
}