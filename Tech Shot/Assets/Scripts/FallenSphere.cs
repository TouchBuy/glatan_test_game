using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenSphere : MonoBehaviour {

    public GameObject sphere;

    //更新
    void Update () {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)) {
            Instantiate(sphere);
        }
    }
}
