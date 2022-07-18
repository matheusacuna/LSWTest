using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using UnityEngine.UI;


public enum Character {Player, NPC,};
public class DisplayInventory : MonoBehaviour
{
    public Character character;
    public Inventory inventory;
    public GameObject itemDefault;
    public Transform grid;

    private void OnEnable()
    {
        CreateDisplay(inventory.itens);
    }

    private void OnDisable()
    {
        for (int i = 0; i < grid.childCount; i++)
        {
            Destroy(grid.GetChild(i).gameObject);
        }
    }

    public void CreateDisplay(List<Item> list)
    {
            if(character == Character.NPC)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var obj = Instantiate(itemDefault, grid);
                    obj.name = list[i].nameItem;
                    obj.GetComponent<ValuesItem>().item = inventory.itens[i];
                    obj.transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().enabled = true;
                    obj.transform.GetChild(0).GetChild(2).gameObject.SetActive(true);
                    obj.transform.GetChild(0).transform.Find("Icon").GetComponent<Button>().onClick.AddListener(() => ShoppingManager.instance.GetItem(obj.GetComponent<ValuesItem>().item, obj));
                }
            } 

            if(character == Character.Player)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var obj = Instantiate(itemDefault, grid);
                    obj.name = list[i].nameItem;
                    obj.GetComponent<ValuesItem>().item = inventory.itens[i];
                    obj.transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>().enabled = false;
                    obj.transform.GetChild(0).GetChild(2).gameObject.SetActive(false);
                    obj.transform.GetChild(0).transform.Find("Icon").GetComponent<Button>().onClick.AddListener(() => ShoppingManager.instance.GetItem(obj.GetComponent<ValuesItem>().item, obj));
                }
            }    
    }

    public void VisualizeEquips()
    {
        Debug.Log("");
    }

    //public void VerifyAmountItens()
    //{
    //    List<Item> itensInventory = new List<Item>();

    //    for (int i = 0; i < grid.childCount; i++)
    //    {
    //        itensInventory.Add(grid.GetChild(i).GetComponent<ValuesItem>().item);
    //    }

    //    List<Item> newList = inventory.itens.Where(i => !itensInventory.Contains(i)).ToList();

    //    CreateDisplay(newList);
    //}
}
