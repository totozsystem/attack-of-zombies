using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	public GameObject bullet;
	public float moveSpeed = 0.1f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// 移動
		if (Input.GetKey(KeyCode.D)){
			this.transform.position += new Vector3(moveSpeed, 0.0f, 0.0f);
		}
		if (Input.GetKey(KeyCode.A)){
			this.transform.position -= new Vector3(moveSpeed, 0.0f, 0.0f);
		}

		// 噛みつき
		if (Input.GetKey(KeyCode.Return)){
		}

		// 弾発射
		if (Input.GetKeyDown(KeyCode.Space)){
			Instantiate (bullet, this.transform.position, Quaternion.identity);
		}
	}
}
