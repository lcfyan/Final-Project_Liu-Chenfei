using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator animator;
    private bool isWalking;

    void Start()
    {
        // 获取Animator组件
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 检测WASD键

        float verticalInput = Input.GetAxis("Vertical");

        // 更新布尔参数
        isWalking = (verticalInput != 0f);

        // 设置Animator中的布尔参数
        animator.SetBool("IsWalking", isWalking);

        // 处理角色移动逻辑，你可以根据具体需求实现移动逻辑
        // 这里只是一个简单的示例
        Vector3 movement = new Vector3(0f, 0f, verticalInput);
        transform.Translate(movement * Time.deltaTime);
    }
}