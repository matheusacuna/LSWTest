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
        switch(ShoppingManager.instance.itemSelected.typeEquips)
        {
            case Equips.Hair:
                GetEquipsParts(equipsPlayer.hair);
                break;
            case Equips.Shirt:
                GetEquipsParts(equipsPlayer.Shirt);
                break;
            case Equips.Pants:
                GetEquipsParts(equipsPlayer.pants);
                break;
        }
    }

    private void GetEquipsParts(SpriteRenderer[] spriteReference)
    {
        for (int i = 0; i < spriteReference.Length; i++)
        {
            spriteReference[i].sprite = ShoppingManager.instance.itemSelected.sprites[i];
        }
    }

    [System.Serializable]
    public class EquipsPlayer
    {
        public SpriteRenderer[] hair;
        public SpriteRenderer[] Shirt;
        public SpriteRenderer[] pants;
    }
}
