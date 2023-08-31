using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float interval = 0.2f; // 何秒間隔で撃つか
    private float timer = 2f;　// 時間カウント用のタイマー

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // 水平方向
        float dx = Input.GetAxis("Horizontal") * Time.deltaTime * 8f;

        transform.position = new Vector3(
            // オブジェクトが移動できる範囲の制限
            Mathf.Clamp(transform.position.x + dx, -2.7f, 2.7f),
            -4.5f,
            0f
        );

        // 一定間隔でbulletPrefabを打ち続ける
        if (timer <= 0.0f)　// 分岐条件変更
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            timer = interval; // 間隔をセット
        }

        // タイマーの値を減らす
        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
        }

    }
}
