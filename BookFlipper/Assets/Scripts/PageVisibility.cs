using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageVisibility : MonoBehaviour
{
    [SerializeField] GameObject pageItems;
    [SerializeField] Material blankPage;
    [SerializeField] Material imagePage;
 //   [SerializeField] Material homePage;

    private void Start()
    {
        pageItems.SetActive(true);
        this.GetComponent<SkinnedMeshRenderer>().material = blankPage;
    }
    public void HideItems()
    {
        pageItems.SetActive(false);
        this.GetComponent<SkinnedMeshRenderer>().material = imagePage;
    }

    public void ShowItems()
    {
        pageItems.SetActive(true);
 //       this.GetComponent<SkinnedMeshRenderer>().material = homePage;

    }
}
