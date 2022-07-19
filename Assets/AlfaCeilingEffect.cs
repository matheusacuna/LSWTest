using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlfaCeilingEffect : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            obj.GetComponent<Animator>().Play("ceilingFade");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            obj.GetComponent<Animator>().Play("ceilingFadeOut");
        }
    }
}
