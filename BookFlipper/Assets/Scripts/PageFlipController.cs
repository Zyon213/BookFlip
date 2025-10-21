using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PageFlipController : MonoBehaviour
{
    [SerializeField] private GameObject[] pagePrefab;
    private int pageCount = 0;

    public void NextPage()
    {
        if (pageCount < pagePrefab.Count())
        {
            pagePrefab[pageCount].GetComponent<Animator>().SetTrigger("Next");
            Transform childTrans = pagePrefab[pageCount].transform.Find("Page");
            GameObject child = childTrans.gameObject;
            child.GetComponent<PageVisibility>().HideItems();
       
            pageCount++;
            Debug.Log(pageCount);
        }
    }

    public void PrevPage()
    {
        if (pageCount > 0)
        {
            Debug.Log(pageCount);

            pageCount--;
            pagePrefab[pageCount].GetComponent<Animator>().SetTrigger("Prev");
        }
    }
}
