using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider;

    void Update()
    {
        // 获取AD键输入
        float horizontalInput = Input.GetAxis("Horizontal");

        // 如果按下AD键，阻止滑块的值变化
        if (horizontalInput != 0f)
        {
            slider.interactable = false;
        }
        else
        {
            // 如果未按下AD键，允许滑块的值变化
            slider.interactable = true;
        }
    }
}
