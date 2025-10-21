using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
 //   public static GameManager Instance;
    public GameObject[] pages;
    /*
      /private void Awake()
      {
          if (Instance != null && Instance != this)
              Destroy(gameObject);
          else
          {
              Instance = this;
              DontDestroyOnLoad(gameObject);
          }
          SceneManager.sceneLoaded += OnSceneLoaded;
       //   HidePages();

      }
    */

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


  /*  
    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
        HidePages() ;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        pages = GameObject.FindGameObjectsWithTag("Page");
    }
    */
}
