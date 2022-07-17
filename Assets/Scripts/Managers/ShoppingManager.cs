using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingManager : MonoBehaviour
{
    [SerializeField] CoinManager coinManager;
    [SerializeField] Inventory playerInventory;
    [SerializeField] Inventory merchantInventory;

    private Item itemSelected;
    private GameObject objectSelected;

    public static ShoppingManager instance;
    private bool selected;

    private void Awake()
    {
        instance = this;
    }

    public void GetItem(Item item, GameObject obj)
    {
        selected = true;
        itemSelected = item;
        objectSelected = obj;
    }

    public void BuyItem()
    {
        if(selected)
        {
            if(itemSelected.price <= coinManager.amountCoin)
            {
                coinManager.DecrementCoin(itemSelected.price);
                playerInventory.itens.Add(itemSelected);
                merchantInventory.itens.Remove(itemSelected);
                Destroy(objectSelected);
            }
        }
        selected = false;
    }

    public void SellItem()
    {
        Debug.Log("vendeu");
    }
}
