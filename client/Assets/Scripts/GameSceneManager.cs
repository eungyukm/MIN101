using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    // Singleton
    public static GameSceneManager instance;

    public static GameSceneManager Get()
    {
        if (instance == null)
        {
            // FindObjectOfType은 씬 내에 모든 게임 오브젝트에서 SceneManager를 찾는 코드
            instance = FindObjectOfType<GameSceneManager>();
        }
        return instance;
    }

    private void Awake()
    {
        // 씬이 전환되어도 파괴되지 않는 코드
        DontDestroyOnLoad(this);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene("Main");
    }
}
