using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CubeInteraction5 : MonoBehaviour
{
    public Slider slider;  // 关联 Slider 组件
    public string targetCubeTag = "Cube5";  // 目标 Cube 的标识（tag）
    public float delayTimeBeforeHide = 3f;  // 第一次等待的时间
    public float delayTimeAfterShow = 2f;  // 第二次等待的时间
    public AudioClip disappearSound;  // 消失时的音效
    private Animator animator;
    private GameObject[] cubes;  // 保存 Cube 引用
    private AudioSource audioSource;

    void Start()
    {
        // 获取 Animator 组件
        animator = GetComponent<Animator>();

        // 获取 AudioSource 组件
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // 获取 Slider 的值
        float sliderValue = slider.value;

        // 检测玩家是否与 Cube1 碰撞，同时 Slider 数值在 2/3 及以上，并且角色处于 "walk3" 状态
        if (IsPlayerCollidingWithCube1() && sliderValue > 2f / 3f && animator.GetCurrentAnimatorStateInfo(0).IsName("walk3"))
        {
            // 启动协程
            StartCoroutine(DelayedCubeInteraction());
        }
    }

    bool IsPlayerCollidingWithCube1()
    {
        // 检测玩家是否与 Cube1 碰撞的逻辑，可以根据实际需要进行实现
        // 这里假设 Cube1 具有 Collider 组件，并且玩家也具有 Collider 组件
        Collider playerCollider = GetComponent<Collider>();
        Collider cubeCollider = GameObject.FindGameObjectWithTag(targetCubeTag)?.GetComponent<Collider>();

        // 判断是否碰撞
        if (playerCollider != null && cubeCollider != null)
        {
            return playerCollider.bounds.Intersects(cubeCollider.bounds);
        }

        return false;
    }

    IEnumerator DelayedCubeInteraction()
    {
        // 查找所有标识为 targetCubeTag 的 Cube 对象
        cubes = GameObject.FindGameObjectsWithTag(targetCubeTag);

        // 第一次等待 3 秒
        yield return new WaitForSeconds(delayTimeBeforeHide);

        // 播放消失时的音效
        PlayDisapperSound();

        // 遍历所有 Cube 对象
        foreach (GameObject cube in cubes)
        {
            // 隐藏目标 Cube 对象
            cube.SetActive(false);
        }

        // 第二次等待 2 秒
        yield return new WaitForSeconds(delayTimeAfterShow);

        // 遍历保存的 Cube 引用
        foreach (GameObject cube in cubes)
        {
            // 显示目标 Cube 对象
            cube.SetActive(true);
        }
    }

    void PlayDisapperSound()
    {
        // 检查是否有音效文件和 AudioSource 组件
        if (disappearSound != null && audioSource != null)
        {
            // 播放音效
            audioSource.PlayOneShot(disappearSound);
        }
    }
}
