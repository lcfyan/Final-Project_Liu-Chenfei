using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyControllerC : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // 检测触发器内的对象的标签是否为"Ball2"
        if (other.CompareTag("Ball1"))
        {
            // 如果是"Ball2"，销毁当前的 Box 对象
            Destroy(gameObject);
        }
        else if (other.CompareTag("Ball2"))
        {
            // 如果是"Ball2"，销毁当前的 Box 对象
            Destroy(gameObject);
        }
        else if (other.CompareTag("Ball3"))
        {
            // 如果是"Ball2"，销毁当前的 Box 对象
            Destroy(gameObject);
        }



    }
}
