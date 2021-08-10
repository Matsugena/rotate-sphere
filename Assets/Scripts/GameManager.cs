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

    // Update is called once per frame
    void Update () {
        sphere.Rotate ();
    }

    void FixedUpdate () {
        sphereOnFixedUpdate.Rotate ();
    }

    void OnGUI () {
        sphereOnGui.Rotate ();
    }
}