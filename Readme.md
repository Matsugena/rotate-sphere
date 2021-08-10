# difference of OnGUI and Update

## description

``` c#


    void Update () {
        sphere.Rotate (); // Inner black sphere
    }

    void FixedUpdate () {
        sphereOnFixedUpdate.Rotate (); // Outer black sphere
    }

    void OnGUI () {
        sphereOnGui.Rotate (); // Yellow sphere
    }

```
![rotate_sphere_sample](https://user-images.githubusercontent.com/43107404/128822644-aa6f5a77-d2cc-4175-8796-8a72236e4a7b.gif)
