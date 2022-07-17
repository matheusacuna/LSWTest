using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPlayer : MonoBehaviour
{
    [SerializeField] private Inventory inventoryPlayer;
    [SerializeField] private PlayerController player;

    public void UseItem()
    {
        player.GetComponent<SpriteRenderer>().sprite = ShoppingManager.instance.itemSelected.sprite;
    }
}
