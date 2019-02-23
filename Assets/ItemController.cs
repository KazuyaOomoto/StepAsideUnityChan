using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour {

	//カメラのオブジェクト
	private new GameObject camera;

	// Use this for initialization
	void Start(){
		//カメラのオブジェクトを取得
		camera = GameObject.Find ("Main Camera");
	}

	// Update is called once per frame
	void Update () {

		//画面外に出たら破棄する
		if (this.transform.position.z <= this.camera.transform.position.z){
			Destroy (gameObject);
		}
	}
}
