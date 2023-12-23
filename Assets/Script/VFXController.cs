using UnityEngine;

public class VFXController : MonoBehaviour
{
    public GameObject vfx1; // 关联 VFX1 的 GameObject
    public GameObject vfx2; // 关联 VFX2 的 GameObject
    public GameObject vfx3; // 关联 VFX3 的 GameObject

    private Animator animator;

    void Start()
    {
        // 获取 Animator 组件
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 根据当前 Walk 状态触发不同的特效
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("walk1"))
        {
            ActivateVFX(vfx1);
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("walk2"))
        {
            ActivateVFX(vfx2);
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("walk3"))
        {
            ActivateVFX(vfx3);
        }
        else
        {
            DeactivateAllVFX();
        }
    }

    // 激活指定的特效并关闭其他特效
    void ActivateVFX(GameObject vfx)
    {
        vfx.SetActive(true);

        // 关闭其他特效
        if (vfx != vfx1) vfx1.SetActive(false);
        if (vfx != vfx2) vfx2.SetActive(false);
        if (vfx != vfx3) vfx3.SetActive(false);
    }

    // 关闭所有特效
    void DeactivateAllVFX()
    {
        vfx1.SetActive(false);
        vfx2.SetActive(false);
        vfx3.SetActive(false);
    }
}
