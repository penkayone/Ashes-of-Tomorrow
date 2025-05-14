
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void AddFoodButton()
    {
        ResourceManager.Instance.AddFood(1);
    }
}
