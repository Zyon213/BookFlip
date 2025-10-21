using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] pages;

    private void Start()
    {
        HidePages();
    }
    public void HidePages()
    {
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].gameObject.SetActive(false);
        }
    }

    public GameObject ShowPage(int index)
    {
        return pages[index];
    }
}
