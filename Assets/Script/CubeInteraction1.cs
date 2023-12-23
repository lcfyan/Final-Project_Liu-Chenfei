using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CubeInteraction : MonoBehaviour
{
    public Slider slider;  // 关联 Slider 组件
    public string targetCubeTag = "Cube1";  // 设置目标 Cube 的标识（tag）
    public float delayTime = 3f;  // 设置延时时间
    private Animator animator;

    void Start()
    {
        // 获取 Animator 组件
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 获取 Slider 的值
        float sliderValue = slider.value;

        // 检测 Slider 数值是否在 2/3 及以上，并且角色处于 "walk3" 状态
        if (sliderValue >= 2f / 3f && animator.GetCurrentAnimatorStateInfo(0).IsName("walk3"))
        {
            // 启动协程
            StartCoroutine(DelayedCubeInteraction());
        }
    }

    IEnumerator DelayedCubeInteraction()
    {
        // 等待延时时间
        yield return new WaitForSeconds(delayTime);

        // 查找所有标识为 targetCubeTag 的 Cube 对象
        GameObject[] cubes = GameObject.FindGameObjectsWithTag(targetCubeTag);

        // 遍历所有 Cube 对象
        foreach (GameObject cube in cubes)
        {
            // 隐藏目标 Cube 对象
            cube.SetActive(false);
        }
    }
}
