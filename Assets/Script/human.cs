using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class human : MonoBehaviour {

	public GameObject zombie;

	// HP
	public int life = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// HPが0以下の時に破壊
		if (life <= 0) {
			Destroy(this.gameObject);
			Debug.Log ("Destroy");

			// ゾンビ生成
			Instantiate (zombie, this.transform.position, Quaternion.identity);
			Debug.Log ("human infected!");
		}
	}

	// 当たり判定
	void OnCollisionEnter2D(Collision2D col)
	{
		// タグ取得
		if(col.gameObject.tag == "bullet")
		{
			Debug.Log ("hit");
			life --;
		}
	}
}
