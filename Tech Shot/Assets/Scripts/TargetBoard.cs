using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBoard : MonoBehaviour {

    public GameObject target_board;
    public GameObject player_model;

	// Use this for initialization
	void Start () {
        for (int count=0; count<100; count++) {
            //板を配置する座標をランダムに決定
            float x = Random.Range(-50.0f, 50.0f);
            float y = Random.Range(target_board.transform.localScale.y/2, 50.0f);
            float z = Random.Range(-50.0f, 50.0f);
            //板をプレイヤーの方向を向くようにして配置
            Instantiate(target_board, new Vector3(x,y,z), Quaternion.identity).transform.LookAt(this.player_model.transform);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
