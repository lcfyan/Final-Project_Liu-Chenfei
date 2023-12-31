using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoRestart : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball2"))
        {
            // 如果碰到了 "Ball2"，1秒后调用 RestartScene 函数
            Invoke("RestartScene", 1.5f);
        }
        else if (collision.gameObject.CompareTag("Ball3"))
        {
            // 如果碰到了 "Ball2"，1秒后调用 RestartScene 函数
            Invoke("RestartScene", 1.5f);
        }
    }

    // 重新加载场景的函数
    void RestartScene()
    {
        // 获取当前场景的索引
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // 重新加载当前场景
        SceneManager.LoadScene(currentSceneIndex);
    }
}
