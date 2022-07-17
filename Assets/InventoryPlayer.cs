using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPlayer : MonoBehaviour
{
    [SerializeField] private Inventory inventoryPlayer;

    public void UseItem()
    {
        Debug.Log("usou item");
    }
}
