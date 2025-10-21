using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LangSelector : MonoBehaviour
{
 //   [SerializeField] private GameObject prevPage;
    [SerializeField] private GameObject pagePrefab;
    [SerializeField] private GameObject nextPageItems;
    [SerializeField] private GameObject languagePage;
    [SerializeField] private GameObject LeftPage;
    [SerializeField] private Material leftPageMaterial;
    //    [SerializeField] Material imagePage;

    //   [SerializeField] private Material nextPageMaterial;


    private void Start()
    {
        nextPageItems.SetActive(false);
    }
    private void OnMouseDown()
    {

        LeftPage.GetComponent<MeshRenderer>().material = leftPageMaterial;

        pagePrefab.GetComponent<Animator>().SetTrigger("Next");
        Transform childTrans = pagePrefab.transform.Find("Page");
        GameObject child = childTrans.gameObject;
        child.GetComponent<PageVisibility>().HideItems();


        // enable the next page
        nextPageItems.SetActive(true);

        nextPageItems.GetComponent<Animator>().SetTrigger("Reveal");
    }

}
