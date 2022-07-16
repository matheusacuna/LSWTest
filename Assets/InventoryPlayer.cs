using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPlayer : MonoBehaviour
{
    [SerializeField] private Inventory inventory;
    [SerializeField] private DisplayInventory displayInventory;
    // Start is called before the first frame update
    void Start()
    {
        displayInventory.inventory = inventory;
    }

    private void Update()
    {
       
    }
}
