using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    public Slider slider;

    void Start()
    {
        // 获取Animator组件
        animator = GetComponent<Animator>();

        // 获取Slider组件
        slider = FindObjectOfType<Slider>(); // 或者通过Inspector手动关联
    }

    void Update()
    {

        // 获取Slider的值
        float sliderValue = slider.value;

        // 根据Slider的值触发不同的Walk状态
        if (sliderValue >= 0f && sliderValue < 1f / 3f)
        {
            // 触发 Walk1 的行为
            animator.SetTrigger("Walk1Trigger");
        }
        else if (sliderValue >= 1f / 3f && sliderValue < 2f / 3f)
        {
            // 触发 Walk2 的行为
            animator.SetTrigger("Walk2Trigger");
        }
        else if (sliderValue >= 2f / 3f && sliderValue <= 1f)
        {
            // 触发 Walk3 的行为
            animator.SetTrigger("Walk3Trigger");
        }
    }
}