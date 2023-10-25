using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public Text levelDisplay;           // ���� �ܰ� ǥ�� UI
    public Image levelImage;            // ������ ���� �ٲ� �̹����� ǥ���ϴ� UI
    public Sprite[] levelImages;        // ���� �̹��� �迭

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
        levelImage.sprite = levelImages[currentLevel - 1];  // �̹��� �迭�� 0���� �����ϹǷ�
    }

    private void Start()
    {
        UpdateLevelDisplay();
    }
}
