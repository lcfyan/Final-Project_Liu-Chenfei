using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject uiPanel; // 弹出的 UI 面板

    // 显示 UI 面板
    public void ShowUI()
    {
        uiPanel.SetActive(true);
    }

    // 隐藏 UI 面板
    public void HideUI()
    {
        uiPanel.SetActive(false);
    }
}