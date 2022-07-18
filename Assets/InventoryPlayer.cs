using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPlayer : MonoBehaviour
{
    [SerializeField] private Inventory inventoryPlayer;
    [SerializeField] private PlayerController player;
    public EquipsPlayer equipsPlayer;

    public void UseItem()
    {
        equipsPlayer.bodyParts[0].sprite = ShoppingManager.instance.itemSelected.sprite;
    }

    [System.Serializable]
    public class EquipsPlayer
    {
        public List<SpriteRenderer> bodyParts = new List<SpriteRenderer>();

    }
}
