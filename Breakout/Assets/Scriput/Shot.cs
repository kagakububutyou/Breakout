using UnityEngine;
using System.Collections;


public class Shot : MonoBehaviour {

    /// <summary>
    /// スピード
    /// </summary>
    [SerializeField]
    private Vector3 Speed = new Vector3(0, 0, 0);
    /// <summary>
    /// 弾が発射されたかどうか
    /// </summary>
    private bool isShot = false;

    [SerializeField]
    private GameObject obj = null;


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
        Horizontal();
        BaallShot();
	}

    /// <summary>
    /// 弾の発射
    /// </summary>
    private void BaallShot()
    {
        if (isShot) return;

        if (Input.GetButtonDown("Shot"))
        {
            // 速度を設定
            gameObject.GetComponent<Rigidbody>().velocity = Speed;
            isShot = true;
        }
    }
    /// <summary>
    /// 弾が発射されてなかったらObjectと同じ位置に動く
    /// </summary>
    private void Horizontal()
    {
        if (isShot) return;

        transform.position = new Vector3(obj.transform.position.x,0,0);

    }
}
