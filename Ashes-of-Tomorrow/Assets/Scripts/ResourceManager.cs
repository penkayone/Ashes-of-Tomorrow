using TMPro;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance;

    public int food = 0;
    public TMP_Text foodText;

    private void Awake()
    {
        Instance = this;
    }

    public void AddFood(int amount)
    {
        food += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (foodText != null)
            foodText.text = "Food: " + food;
    }

    // 👇 Добавь вот этот метод сюда:
    public void AddEnergy(int amount)
    {
        Debug.Log("Energy added: " + amount);
        // Можешь завести отдельную переменную energy, если хочешь её хранить.
    }
}
