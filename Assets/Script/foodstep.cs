using UnityEngine;

public class foodstep : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;

    public AudioClip footstepSound;

    // 不同 Walk 状态对应的音量
    public float walkVolume1 = 0.2f;
    public float walkVolume2 = 0.5f;
    public float walkVolume3 = 1.0f;

    void Start()
    {
        // 获取 Animator 组件
        animator = GetComponent<Animator>();

        // 添加 AudioSource 组件
        audioSource = gameObject.AddComponent<AudioSource>();

        // 确保音频剪辑不为 null
        if (footstepSound == null)
        {
            Debug.LogError("请分配脚步声音频剪辑！");
        }
    }

    // 在动画事件中调用，用于播放脚步声音
    public void PlayFootstepSound()
    {
        // 获取当前动画状态的名称
        string currentAnimationState = GetCurrentAnimationState();

        // 根据当前 Walk 状态设置音量
        if (currentAnimationState == "walk1")
        {
            PlayStep(walkVolume1);
        }
        else if (currentAnimationState == "walk2")
        {
            PlayStep(walkVolume2);
        }
        else if (currentAnimationState == "walk3")
        {
            PlayStep(walkVolume3);
        }
    }

    // 获取当前动画状态的名称
    private string GetCurrentAnimationState()
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        return stateInfo.IsName("Base Layer.walk1") ? "walk1" :
               stateInfo.IsName("Base Layer.walk2") ? "walk2" :
               stateInfo.IsName("Base Layer.walk3") ? "walk3" : "";
    }

    // 播放脚步声音的方法
    private void PlayStep(float volume)
    {
        // 设置 AudioSource 的音量
        audioSource.volume = volume;

        // 分配音频剪辑给 AudioSource
        audioSource.clip = footstepSound;

        // 播放音频
        audioSource.Play();
    }
}

