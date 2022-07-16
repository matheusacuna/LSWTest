using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Inventory", menuName = "ScriptableObject/Inventory", order = 0)]
public class Inventory : ScriptableObject
{
    public List<Item> itens = new List<Item>();
    public string nameInventory;
}