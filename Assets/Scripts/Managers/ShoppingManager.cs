using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingManager : MonoBehaviour
{
    [SerializeField] CoinManager coinManager;
    [SerializeField] Inventory playerInventory;
    [SerializeField] Inventory merchantInventory;
    [SerializeField] PlayerController player;

    [Header("Buttons")]
    [SerializeField] GameObject buttonBuyItem;
    [SerializeField] GameObject buttonSellItem;

    [HideInInspector] public Item itemSelected;
    [HideInInspector] public GameObject objectSelected;


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

        buttonBuyItem.SetActive(true);
        buttonSellItem.SetActive(true);
    }

    public void BuyItem()
    {
        if(selected)
        {
            if(itemSelected.purchasePrice <= coinManager.amountCoin)
            {
                coinManager.DecrementCoin(itemSelected.purchasePrice);
                playerInventory.itens.Add(itemSelected);
                merchantInventory.itens.Remove(itemSelected);
                Destroy(objectSelected);
            }
        }
        selected = false;
    }

    public void SellItem()
    {
        if (selected)
        {          
           coinManager.IncrementCoin(itemSelected.resalePrice);
           playerInventory.itens.Remove(itemSelected);
           merchantInventory.itens.Add(itemSelected);
           Destroy(objectSelected);
        }
        selected = false;
    }

    public void UseItem()
    {
        player.GetComponent<SpriteRenderer>().sprite = itemSelected.sprite;
    }
}
