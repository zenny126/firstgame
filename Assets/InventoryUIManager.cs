using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIManager : MonoBehaviour
{
    [SerializeField] private Inventory inventory;
    [SerializeField] private GameObject itemUIPrefab;
    [SerializeField] private Transform itemsParent;

    private List<GameObject> itemUIInstances = new List<GameObject>();

    private void OnEnable()
    {
        UpdateInventoryUI();
    }

    public void UpdateInventoryUI()
    {
        // Clear existing items
        foreach (GameObject itemUI in itemUIInstances)
        {
            Destroy(itemUI);
        }
        itemUIInstances.Clear();

        // Populate with new items
        foreach (ItemInventory item in inventory.Instance.items)
        {
            GameObject itemUI = Instantiate(itemUIPrefab, itemsParent);
            
            itemUI.transform.Find("ItemName").GetComponent<Text>().text = item.itemProfile.itemName;
            itemUI.transform.Find("ItemCount").GetComponent<Text>().text = item.itemCount.ToString();

            itemUIInstances.Add(itemUI);
        }
    }
}
