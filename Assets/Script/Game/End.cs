using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverCollision : MonoBehaviour
{
    public UIManager uiManager; // 引用 UIManager 脚本
    void OnCollisionEnter2D(Collision2D collision)
    {
        // 检测是否碰撞到了带有 "Ball5" 标签的物体
        if (collision.gameObject.CompareTag("Ball4"))
        {
            LoadNextScene();
        }
        else if (collision.gameObject.CompareTag("Ball1"))
        {
            // 与 "Ball1" 物体碰撞，弹出 UI
            uiManager.ShowUI();
        }
    }
    void LoadNextScene()
    {
        // 获取当前场景的 Build Index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // 加载下一个场景的 Build Index
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
