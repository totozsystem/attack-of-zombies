using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	public int life = 1000;
	public float moveSpeed = 0.3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// HPが0以下の時に破壊
		if (life <= 0) {
			Destroy(this.gameObject);
		}

		// 移動処理
		this.transform.position += new Vector3(moveSpeed, 0.0f, 0.0f);

		// HPを減らす
		life --;
	}
	// 当たり判定
	void OnCollisionEnter2D(Collision2D col)
	{
		// タグ取得
		if(col.gameObject.tag == "human")
		{
			// 人間に当たったら破壊
			Destroy(this.gameObject);
		}
	}
}
