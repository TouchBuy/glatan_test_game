using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenSphere : MonoBehaviour {

    public GameObject sphere;

    //更新
    void Update () {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)) {
            for (int i=0; i<10; i++)
            {
                Instantiate(sphere);
            }
        }
    }
}
