using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // 检测碰撞对象的标签是否为"Ball2"
        if (collision.gameObject.CompareTag("Ball2"))
        {
            // 如果是"Ball2"，销毁当前的slice对象
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Ball4"))
        {
            // 如果是"Ball2"，销毁当前的slice对象
            Destroy(gameObject);
        }
    }
}