using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipBack : MonoBehaviour
{
    [SerializeField] private GameObject pagePrefab;
    [SerializeField] private GameObject homePage;

    private void Start()
    {
    //    nextPagePrefab.SetActive(false);
    }
    private void OnMouseDown()
    {
        // play this page flip animation and hide the sprites
        pagePrefab.GetComponent<Animator>().SetTrigger("Prev");
        Transform childTrans = pagePrefab.transform.Find("Page");
        GameObject child = childTrans.gameObject;
  //      child.GetComponent<PageVisibility>().ShowItems();

        // enable the next page
     //   nextPagePrefab.SetActive(true);

    //    nextPagePrefab.GetComponent<Animator>().SetTrigger("Reveal");
    }
}
