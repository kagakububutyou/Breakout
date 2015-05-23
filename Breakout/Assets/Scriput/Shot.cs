using UnityEngine;
using System.Collections;


public class Shot : MonoBehaviour {

    [SerializeField]
    private Vector3 Speed = new Vector3(0, 0, 0);


    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
	private void Start () 
    {
	
	}

    /// <summary>
    /// 更新は、フレームごとに一度と呼ばれている
    /// </summary>
	private void Update () 
    {
        BaallShot();
	}

    /// <summary>
    /// 弾の発射
    /// </summary>
    private void BaallShot()
    {
        if (Input.GetButtonDown("Shot"))
        {
            // 速度を設定
            gameObject.GetComponent<Rigidbody>().velocity = Speed;

        }
    }
}
