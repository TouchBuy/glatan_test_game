using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour {

    private GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

    //更新
    void Update () {
        cube.transform.position = new Vector3(1, 0, 0);
    }
}
