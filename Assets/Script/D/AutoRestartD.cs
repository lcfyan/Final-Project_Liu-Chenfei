using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoRestartD : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball2"))
        {
            // 如果碰到了 "Ball2"，1秒后调用 RestartScene 函数
            Invoke("RestartScene", 0.5f);
        }
        else if (collision.gameObject.CompareTag("Ball3"))
        {
            // 如果碰到了 "Ball2"，1秒后调用 RestartScene 函数
            Invoke("RestartScene", 0.5f);
        }
    }

    // 重新加载场景的函数
    void RestartScene()
    {
        // 获取当前场景的索引
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        CoinManagerD coinManagerInstance = new CoinManagerD();
        // 重新加载当前场景
        SceneManager.LoadScene(currentSceneIndex);
        // 在重新加载后重置金币数量为1
        coinManagerInstance.ResetCoins();
    }
}
