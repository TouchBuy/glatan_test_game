using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject PlayerModel;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad)) {
            PlayerModel.transform.position += new Vector3(1, 0, 0);
        }
    }
}
