// BallCollider12 脚本
using UnityEngine;

public class BallCollider34 : MonoBehaviour
{
    public PlayerController playerController; // 引用PlayerController脚本

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball4")) // 碰撞对象是小球2
        {
            // 小球1静止
            Rigidbody2D rb1 = GetComponent<Rigidbody2D>();


            // 切换玩家控制的小球，并传递速度信息
            playerController.SwitchControlledBall();

            Destroy(gameObject);
        }
    }
}
