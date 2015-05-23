using UnityEngine;
using System.Collections;
/// <summary>
/// 左右移動
/// </summary>
public class PlayerHorizontal : MonoBehaviour {

    [SerializeField]
    private float Speed = 0.0f;     /// スピード
                                    /// 
    private float value = 0.0f;
    private float velocity = 0.0f;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
	void Start () 
    {
	
	}

    /// <summary>
    /// 更新は、フレームごとに一度と呼ばれている
    /// </summary>
	void Update () 
    {
        Move();
	}

    /// <summary>
    /// 左右移動
    /// </summary>
    public void Move()
    {
        value = Input.GetAxisRaw("Horizontal");
        velocity = value * Speed * Time.deltaTime;

        transform.Translate(new Vector3(velocity, 0, 0));

    }
}
