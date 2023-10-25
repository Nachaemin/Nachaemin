using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public Text levelDisplay;           // 현재 단계 표시 UI
    public Image levelImage;            // 레벨에 따라 바뀔 이미지를 표시하는 UI
    public Sprite[] levelImages;        // 레벨 이미지 배열

    private int currentLevel = 1;

    public void NextLevel()
    {
        currentLevel = Mathf.Clamp(currentLevel + 1, 1, 3);
        UpdateLevelDisplay();
    }

    public void PreviousLevel()
    {
        currentLevel = Mathf.Clamp(currentLevel - 1, 1, 3);
        UpdateLevelDisplay();
    }

    public void StartGame()
    {
        SceneManager.LoadScene($"Level{currentLevel}");
    }

    private void UpdateLevelDisplay()
    {
        levelDisplay.text = $"Level {currentLevel}";
        levelImage.sprite = levelImages[currentLevel - 1];  // 이미지 배열은 0부터 시작하므로
    }

    private void Start()
    {
        UpdateLevelDisplay();
    }
}
