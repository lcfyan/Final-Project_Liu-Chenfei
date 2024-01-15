using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinManagerD : MonoBehaviour
{
    public static int coins = 1; // 静态变量，用于跨场景保存金币数量
    public Text coinText; // 用于显示金币数量的 Text UI

    void Start()
    {
        UpdateCoinUI(); // 初始化时更新UI
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // 检测触发器内的对象的标签是否为"Ball2", "Ball3", "Ball4"等等
        if (other.CompareTag("Ball1") || other.CompareTag("Ball2") || other.CompareTag("Ball3") || other.CompareTag("Ball4"))
        {
            // 如果是上述标签的小球，金币数量+1
            coins++;
            UpdateCoinUI(); // 更新UI显示
            Destroy(gameObject); // 销毁金币对象
        }
    }

    void UpdateCoinUI()
    {
        // 更新UI上显示的金币数量
        if (coinText != null)
        {
            coinText.text = "Coins: " + coins.ToString();
        }
    }

    public void ResetCoins()
    {
        // 重置金币数量为0
        coins = 1;
        UpdateCoinUI();
    }
}