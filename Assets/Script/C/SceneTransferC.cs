using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransferC : MonoBehaviour
{
    public UIManager uiManager;
    void OnCollisionEnter2D(Collision2D collision)
    {
        // 检查碰撞对象的标签是否为 "Ball3"
        if (collision.gameObject.CompareTag("Ball3"))
        {
            // 检查场景中是否存在标签为 "Ball2" 的物体
            GameObject ball2 = GameObject.FindWithTag("Ball2");

            if (ball2 == null)
            {
                // 如果不存在 "Ball2"，调用 LoadNextScene 函数
                LoadNextScene();
            }
            else
            {
                uiManager.ShowUI();
                // 如果存在 "Ball2"，可以执行其他逻辑，或者忽略这部分
            }
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
