using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IconManager : MonoBehaviour
{
    public Slider slider;  // 关联 Slider 组件
    public string icon1Tag = "Icon1";  // Icon1 的标识（tag）
    public string icon2Tag = "Icon2";  // Icon2 的标识（tag）
    public string cube1Tag = "Cube1";  // Cube1 的标识（tag）

    private Animator animator;
    private GameObject icon1;
    private GameObject icon2;

    void Start()
    {
        // 获取 Animator 组件
        animator = GetComponent<Animator>();

        // 初始化状态为 Icon1 可见，Icon2 不可见
        icon1 = GameObject.FindGameObjectWithTag(icon1Tag);
        icon2 = GameObject.FindGameObjectWithTag(icon2Tag);
        SetIconVisibility(icon1, true);
        SetIconVisibility(icon2, false);
    }

    void Update()
    {
        // 获取 Slider 的值
        float sliderValue = slider.value;

        // 检测玩家是否符合条件
        if (CheckPlayerConditions(sliderValue))
        {
            // 启动协程，3秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon1, icon2));
        }
    }

    bool CheckPlayerConditions(float sliderValue)
    {
        // 检测玩家是否与 Cube1 碰撞，同时满足其他条件
        return IsPlayerCollidingWithCube1() && sliderValue > 2f / 3f && animator.GetCurrentAnimatorStateInfo(0).IsName("walk3");
    }

    bool IsPlayerCollidingWithCube1()
    {
        // 检测玩家是否与 Cube1 碰撞的逻辑，可以根据实际需要进行实现
        // 这里假设 Cube1 具有 Collider 组件，并且玩家也具有 Collider 组件
        Collider playerCollider = GetComponent<Collider>();
        Collider cube1Collider = GameObject.FindGameObjectWithTag(cube1Tag)?.GetComponent<Collider>();

        // 判断是否碰撞
        if (playerCollider != null && cube1Collider != null)
        {
            return playerCollider.bounds.Intersects(cube1Collider.bounds);
        }

        return false;
    }

    IEnumerator DelayedIconSwitch(GameObject currentIcon, GameObject nextIcon)
    {
        // 等待 3 秒
        yield return new WaitForSeconds(3f);

        // 隐藏当前图标，显示下一个图标
        SetIconVisibility(currentIcon, false);
        SetIconVisibility(nextIcon, true);
    }

    void SetIconVisibility(GameObject icon, bool isVisible)
    {
        // 设置 Icon 对象的激活状态
        if (icon != null)
        {
            icon.SetActive(isVisible);
        }
    }
}
