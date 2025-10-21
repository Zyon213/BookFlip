using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPage : MonoBehaviour
{
    [SerializeField] private GameObject prevPage; 
    [SerializeField] private GameObject pagePrefab;
//   [SerializeField] private GameObject currentPage;
 //   [SerializeField] private GameObject nextPage;
    [SerializeField] private GameObject nextPageItems;
    [SerializeField] private GameObject languagePage;
    [SerializeField] private GameObject LeftPage;
    [SerializeField] private Material leftPageMaterial;
    [SerializeField] private int index;
    [SerializeField] private Material imagePage;

     private GameController gameController;

    //   [SerializeField] private Material nextPageMaterial;

    private GameObject currentPage;
    private void Start()
    {
        nextPageItems.SetActive(false);
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }
    private void OnMouseDown()
    {
        languagePage.SetActive(false);

        // GameManager.Instance.pages[index].SetActive(true);
        currentPage = gameController.ShowPage(index);
        currentPage.SetActive(true);

        LeftPage.GetComponent<MeshRenderer>().material = leftPageMaterial;
  //      nextPage.GetComponent<MeshRenderer>().material = nextPageMaterial;
        if (prevPage.activeSelf)
        {
            prevPage.SetActive(false);
        }
    //    currentPage.SetActive(true);
            // play this page flip animation and hide the sprites
        pagePrefab.GetComponent<Animator>().SetTrigger("Next");
        Transform childTrans = pagePrefab.transform.Find("Page");
        GameObject child = childTrans.gameObject;
        child.GetComponent<PageVisibility>().HideItems();
        child.GetComponent<SkinnedMeshRenderer>().material = imagePage;


        // enable the next page
        nextPageItems.SetActive(true);

        nextPageItems.GetComponent<Animator>().SetTrigger("Reveal");
       
        var nextChild = nextPageItems.transform.GetComponentsInChildren<TextController>(true);
        for (int i = 0; i < nextChild.Length; i++)
        {
            var next = nextChild[i].gameObject;
            if (next != null && !next.activeSelf)
            {
                next.SetActive(true);
            }
        }
    }
}
