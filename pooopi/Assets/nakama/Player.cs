using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 10.0f;

    public float jumpPower;
    private Rigidbody rb;
    private bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        // transformを取得
        Transform myTransform = this.transform;

        // 座標を取得
        Vector3 pos = myTransform.position;
        pos.x += 0.1f;    // x座標へ0.1加算
        //pos.y += 0.01f;    // y座標へ0.01加算
        //pos.z += 0.01f;    // z座標へ0.01加算

        myTransform.position = pos;  // 座標を設定

        Operation();

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping) //空中でジャンプ出来なくした
        {
            rb.velocity = Vector3.up * jumpPower;
            isJumping = true;
        }

    }

    void Operation()
    {
        if (Input.GetKey(KeyCode.A) & transform.position.z < 3.0f) //左
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) & transform.position.z > -3.0f) //右
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision) //地面に着いたらジャンプできる
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }
    }
}
