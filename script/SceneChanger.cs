using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadNextScene()
    {
        // ���� ���� �ε����� �����ɴϴ�.
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // ���� ���� �ε����� ����ϰ�, �ش� ���� �ε��մϴ�.
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
