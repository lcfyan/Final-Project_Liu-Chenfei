using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class BackgroundMusicManager : MonoBehaviour
{
    [System.Serializable]
    public class SceneBGM
    {
        public string sceneName;
        public AudioClip bgm;
    }

    public AudioClip defaultBGM; // 默认背景音乐
    public List<SceneBGM> sceneBGMList; // 场景和对应背景音乐的列表

    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        // 在 Awake 中播放默认背景音乐
        PlayBackgroundMusic(defaultBGM);
    }

    void PlayBackgroundMusic(AudioClip bgm)
    {
        if (audioSource != null && bgm != null)
        {
            audioSource.clip = bgm;
            audioSource.Play();
        }
    }

    // 在每次场景加载时调用
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // 在每次场景卸载时调用
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // 在场景加载完成时调用
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 获取场景名称对应的背景音乐
        AudioClip bgm = GetBGMForScene(scene.name);

        // 播放背景音乐
        PlayBackgroundMusic(bgm);
    }

    // 根据场景名称获取对应的背景音乐
    AudioClip GetBGMForScene(string sceneName)
    {
        // 在场景和背景音乐的列表中查找对应关系
        SceneBGM sceneBGM = sceneBGMList.Find(x => x.sceneName == sceneName);

        // 如果找到对应的背景音乐，则返回它；否则返回默认背景音乐
        return sceneBGM != null ? sceneBGM.bgm : defaultBGM;
    }

    // 在 Inspector 页面中显示一个按钮，用于手动播放默认背景音乐
    [ContextMenu("Play Default BGM")]
    void PlayDefaultBGM()
    {
        PlayBackgroundMusic(defaultBGM);
    }

    // 在 Inspector 页面中显示一个按钮，用于停止背景音乐
    [ContextMenu("Stop BGM")]
    void StopBGM()
    {
        audioSource.Stop();
    }
}
