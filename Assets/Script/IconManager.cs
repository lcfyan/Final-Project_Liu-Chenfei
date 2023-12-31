using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IconManager : MonoBehaviour
{
    public Slider slider;  // 关联 Slider 组件
    public string icon1Tag = "Icon1";  // Icon1 的标识（tag）
    public string icon2Tag = "Icon2";  // Icon2 的标识（tag）
    public string icon3Tag = "Icon3";  // Icon3 的标识（tag）
    public string icon4Tag = "Icon4";  // Icon4 的标识（tag）
    public string icon5Tag = "Icon5";  // Icon1 的标识（tag）
    public string icon6Tag = "Icon6";  // Icon2 的标识（tag）
    public string icon7Tag = "Icon7";  // Icon3 的标识（tag）
    public string icon8Tag = "Icon8";  // Icon4 的标识（tag）
    public string icon9Tag = "Icon9";  // Icon1 的标识（tag）
    public string icon10Tag = "Icon10";  // Icon2 的标识（tag）
    public string icon11Tag = "Icon11";  // Icon3 的标识（tag）
    public string icon12Tag = "Icon12";  // Icon4 的标识（tag）
    public string icon13Tag = "Icon13";  // Icon2 的标识（tag）
    public string icon14Tag = "Icon14";  // Icon3 的标识（tag）
    public string icon15Tag = "Icon15";  // Icon4 的标识（tag）
    public string icon16Tag = "Icon16";  // Icon1 的标识（tag）
    public string icon17Tag = "Icon17";  // Icon2 的标识（tag）
    public string icon18Tag = "Icon18";  // Icon3 的标识（tag）
    public string icon19Tag = "Icon19";  // Icon4 的标识（tag）
    public string icon20Tag = "Icon20";  // Icon2 的标识（tag）
    public string icon21Tag = "Icon21";  // Icon3 的标识（tag）
    public string icon22Tag = "Icon22";  // Icon4 的标识（tag）
    public string icon23Tag = "Icon23";  // Icon2 的标识（tag）
    public string icon24Tag = "Icon24";  // Icon3 的标识（tag）
    public string icon25Tag = "Icon25";  // Icon4 的标识（tag）
    public string icon26Tag = "Icon26";  // Icon2 的标识（tag）
    public string icon27Tag = "Icon27";  // Icon3 的标识（tag）
    public string icon28Tag = "Icon28";  // Icon4 的标识（tag）
    public string icon29Tag = "Icon29";  // Icon2 的标识（tag）
    public string icon30Tag = "Icon30";  // Icon3 的标识（tag）

    public string cube1Tag = "Cube1";  // Cube1 的标识（tag）
    public string cube5Tag = "Cube5";  // Cube2 的标识（tag）
    public string cube3Tag = "Cube3";  // Cube2 的标识（tag）
    public string cube4Tag = "Cube4";  // Cube2 的标识（tag）
    public string cube2Tag = "Cube2";  // Cube2 的标识（tag）
    public string cube7Tag = "Cube7";  // Cube2 的标识（tag）

    private Animator animator;
    private GameObject icon1;
    private GameObject icon2;
    private GameObject icon3;
    private GameObject icon4;
    private GameObject icon5;
    private GameObject icon6;
    private GameObject icon7;
    private GameObject icon8;
    private GameObject icon9;
    private GameObject icon10;
    private GameObject icon11;
    private GameObject icon12;
    private GameObject icon13;
    private GameObject icon14;
    private GameObject icon15;
    private GameObject icon16;
    private GameObject icon17;
    private GameObject icon18;
    private GameObject icon19;
    private GameObject icon20;
    private GameObject icon21;
    private GameObject icon22;
    private GameObject icon23;
    private GameObject icon24;
    private GameObject icon25;
    private GameObject icon26;
    private GameObject icon27;
    private GameObject icon28;
    private GameObject icon29;
    private GameObject icon30;


    void Start()
    {
        // 获取 Animator 组件
        animator = GetComponent<Animator>();

        // 初始化状态为 Icon1 可见，Icon2、Icon3 和 Icon4 不可见
        icon1 = GameObject.FindGameObjectWithTag(icon1Tag);
        icon2 = GameObject.FindGameObjectWithTag(icon2Tag);
        icon3 = GameObject.FindGameObjectWithTag(icon3Tag);
        icon4 = GameObject.FindGameObjectWithTag(icon4Tag);
        icon5 = GameObject.FindGameObjectWithTag(icon5Tag);
        icon6 = GameObject.FindGameObjectWithTag(icon6Tag);
        icon7 = GameObject.FindGameObjectWithTag(icon7Tag);
        icon8 = GameObject.FindGameObjectWithTag(icon8Tag);
        icon9 = GameObject.FindGameObjectWithTag(icon9Tag);
        icon10 = GameObject.FindGameObjectWithTag(icon10Tag);
        icon11 = GameObject.FindGameObjectWithTag(icon11Tag);
        icon12 = GameObject.FindGameObjectWithTag(icon12Tag);
        icon13 = GameObject.FindGameObjectWithTag(icon13Tag);
        icon14 = GameObject.FindGameObjectWithTag(icon14Tag);
        icon15 = GameObject.FindGameObjectWithTag(icon15Tag);
        icon16 = GameObject.FindGameObjectWithTag(icon16Tag);
        icon17 = GameObject.FindGameObjectWithTag(icon17Tag);
        icon18 = GameObject.FindGameObjectWithTag(icon18Tag);
        icon19 = GameObject.FindGameObjectWithTag(icon19Tag);
        icon20 = GameObject.FindGameObjectWithTag(icon20Tag);
        icon21 = GameObject.FindGameObjectWithTag(icon21Tag);
        icon22 = GameObject.FindGameObjectWithTag(icon22Tag);
        icon23 = GameObject.FindGameObjectWithTag(icon23Tag);
        icon24 = GameObject.FindGameObjectWithTag(icon24Tag);
        icon25 = GameObject.FindGameObjectWithTag(icon25Tag);
        icon26 = GameObject.FindGameObjectWithTag(icon26Tag);
        icon27 = GameObject.FindGameObjectWithTag(icon27Tag);
        icon28 = GameObject.FindGameObjectWithTag(icon28Tag);
        icon29 = GameObject.FindGameObjectWithTag(icon29Tag);
        icon30 = GameObject.FindGameObjectWithTag(icon30Tag);

        SetIconVisibility(icon1, true);
        SetIconVisibility(icon2, false);
        SetIconVisibility(icon3, false);
        SetIconVisibility(icon4, false);
        SetIconVisibility(icon5, false);
        SetIconVisibility(icon6, false);
        SetIconVisibility(icon7, false);
        SetIconVisibility(icon8, false);
        SetIconVisibility(icon9, false);
        SetIconVisibility(icon10, false);
        SetIconVisibility(icon11, false);
        SetIconVisibility(icon12, false);
        SetIconVisibility(icon13, false);
        SetIconVisibility(icon14, false);
        SetIconVisibility(icon15, false);
        SetIconVisibility(icon16, false);
        SetIconVisibility(icon17, false);
        SetIconVisibility(icon18, false);
        SetIconVisibility(icon19, false);
        SetIconVisibility(icon20, false);
        SetIconVisibility(icon21, false);
        SetIconVisibility(icon22, false);
        SetIconVisibility(icon23, false);
        SetIconVisibility(icon24, false);
        SetIconVisibility(icon25, false);
        SetIconVisibility(icon26, false);
        SetIconVisibility(icon27, false);
        SetIconVisibility(icon28, false);
        SetIconVisibility(icon29, false);
        SetIconVisibility(icon30, false);

    }

    void Update()
    {
        // 获取 Slider 的值
        float sliderValue = slider.value;

        // 检测玩家是否符合条件，执行相应的图标切换
        if (CheckPlayerConditionsForIconSwitch(sliderValue, cube1Tag, icon2Tag, 1f / 3f, 2f / 3f, "walk2") && !icon2.activeSelf && !icon3.activeSelf && !icon23.activeSelf && !icon24.activeSelf && !icon30.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon1, icon2));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube1Tag, icon3Tag, 1f / 3f, 2f / 3f, "walk2") && !icon1.activeSelf && !icon3.activeSelf && !icon23.activeSelf && !icon24.activeSelf && !icon30.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon2, icon3));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube1Tag, icon4Tag, 1f / 3f, 2f / 3f, "walk2") && !icon1.activeSelf && !icon2.activeSelf && !icon23.activeSelf && !icon24.activeSelf && !icon30.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon3, icon4));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube5Tag, icon5Tag, 2f / 3f, 1f, "walk3") && !icon27.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon4, icon5));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube3Tag, icon6Tag, 0f, 1f / 3f, "walk1") && !icon6.activeSelf && !icon7.activeSelf && !icon17.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon5, icon6));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube3Tag, icon7Tag, 0f, 1f / 3f, "walk1") && !icon5.activeSelf && !icon7.activeSelf && !icon17.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon6, icon7));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube3Tag, icon8Tag, 0f, 1f / 3f, "walk1") && !icon5.activeSelf && !icon6.activeSelf && !icon17.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon7, icon8));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube1Tag, icon9Tag, 0f, 1f / 3f, "walk1"))
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon8, icon9));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube1Tag, icon10Tag, 2f / 3f, 1f, "walk3"))
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon9, icon10));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube3Tag, icon11Tag, 2f / 3f, 1f, "walk3"))
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon10, icon11));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube5Tag, icon12Tag, 1f / 3f, 2f / 3f, "walk2") && !icon12.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon11, icon12));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube5Tag, icon13Tag, 1f / 3f, 2f / 3f, "walk2") && !icon11.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon12, icon13));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube4Tag, icon14Tag, 1f / 3f, 2f / 3f, "walk2"))
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon13, icon14));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube3Tag, icon15Tag, 1f / 3f, 2f / 3f, "walk2") && !icon20.activeSelf && !icon22.activeSelf && !icon25.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon14, icon15));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube2Tag, icon16Tag, 1f / 3f, 2f / 3f, "walk2") && !icon21.activeSelf && !icon26.activeSelf && !icon29.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon15, icon16));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube2Tag, icon17Tag, 0f, 1f / 3f, "walk1"))
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon16, icon17));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube3Tag, icon18Tag, 0f, 1f / 3f, "walk1") && !icon5.activeSelf && !icon6.activeSelf && !icon7.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon17, icon18));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube4Tag, icon19Tag, 0f, 1f / 3f, "walk1") && !icon19.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon18, icon19));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube4Tag, icon20Tag, 0f, 1f / 3f, "walk1") && !icon18.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon19, icon20));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube3Tag, icon21Tag, 1f / 3f, 2f / 3f, "walk2") && !icon14.activeSelf && !icon22.activeSelf && !icon25.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon20, icon21));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube2Tag, icon22Tag, 1f / 3f, 2f / 3f, "walk2") && !icon15.activeSelf && !icon26.activeSelf && !icon29.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon21, icon22));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube3Tag, icon23Tag, 1f / 3f, 2f / 3f, "walk2") && !icon14.activeSelf && !icon20.activeSelf && !icon25.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon22, icon23));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube1Tag, icon24Tag, 1f / 3f, 2f / 3f, "walk2") && !icon1.activeSelf && !icon2.activeSelf && !icon3.activeSelf && !icon24.activeSelf && !icon30.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon23, icon24));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube1Tag, icon25Tag, 1f / 3f, 2f / 3f, "walk2") && !icon1.activeSelf && !icon2.activeSelf && !icon3.activeSelf && !icon23.activeSelf && !icon30.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon24, icon25));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube3Tag, icon26Tag, 1f / 3f, 2f / 3f, "walk2") && !icon14.activeSelf && !icon20.activeSelf && !icon22.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon25, icon26));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube2Tag, icon27Tag, 1f / 3f, 2f / 3f, "walk2") && !icon15.activeSelf && !icon21.activeSelf && !icon29.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon26, icon27));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube5Tag, icon28Tag, 2f / 3f, 1f, "walk3") && !icon4.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon27, icon28));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube7Tag, icon29Tag, 2f / 3f, 1f, "walk3"))
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon28, icon29));
        }
        else if (CheckPlayerConditionsForIconSwitch(sliderValue, cube2Tag, icon30Tag, 1f / 3f, 2f / 3f, "walk2") && !icon15.activeSelf && !icon21.activeSelf && !icon26.activeSelf)
        {
            // 启动协程，2秒后切换图标
            StartCoroutine(DelayedIconSwitch(icon29, icon30));
        }
    }

    bool CheckPlayerConditionsForIconSwitch(float sliderValue, string targetTag, string nextIconTag, float minValue, float maxValue, string requiredState)
    {
        // 检测玩家是否与目标物体碰撞，同时满足其他条件
        return IsPlayerCollidingWithTag(targetTag) && sliderValue >= minValue && sliderValue <= maxValue && IsCurrentAnimatorState(requiredState);
    }

    bool IsPlayerCollidingWithTag(string targetTag)
    {
        // 检测玩家是否与指定 Tag 的物体碰撞的逻辑
        Collider playerCollider = GetComponent<Collider>();
        Collider targetCollider = GameObject.FindGameObjectWithTag(targetTag)?.GetComponent<Collider>();

        if (playerCollider != null && targetCollider != null)
        {
            return playerCollider.bounds.Intersects(targetCollider.bounds);
        }

        return false;
    }

    bool IsCurrentAnimatorState(string stateName)
    {
        // 检查当前的动画状态
        return animator.GetCurrentAnimatorStateInfo(0).IsName(stateName);
    }

    IEnumerator DelayedIconSwitch(GameObject currentIcon, GameObject nextIcon)
    {
        // 等待 2 秒
        yield return new WaitForSeconds(2f);

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
