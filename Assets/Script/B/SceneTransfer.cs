using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball3"))
        {
            // 如果碰到了 "Ball3"，调用 LoadNextScene 函数
            LoadNextScene();
        }
    }

    // 跳转到下一个场景的函数
    void LoadNextScene()
    {
        // 获取当前场景的 Build Index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // 加载下一个场景的 Build Index
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
