using UnityEngine;

public class ExitGame : MonoBehaviour
{
    void Update()
    {
        // 检测按下 Esc 键
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // 调用退出游戏方法
            QuitGame();
        }
    }

    // 退出游戏的方法
    public void QuitGame()
    {
#if UNITY_EDITOR
        // 在编辑器中停止播放
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // 在应用中退出
        Application.Quit();
#endif
    }
}
