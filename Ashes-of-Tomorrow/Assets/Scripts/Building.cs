
using UnityEngine;

public class Building : MonoBehaviour
{
    public enum ResourceType { Food, Energy }
    public ResourceType resourceType;
    public int amountPerClick = 10;

    private void OnMouseDown()
    {
        if (resourceType == ResourceType.Food)
            ResourceManager.Instance.AddFood(amountPerClick);
        else
            ResourceManager.Instance.AddEnergy(amountPerClick);
    }
}
