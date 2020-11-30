﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    [Header("Next Scene Name")]
    [SerializeField]
    private string nextSceneName;
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("hasKey " + gameManager.hasKey);
        if (collision.CompareTag("Player"))
        {
            if (gameManager.hasKey)
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
}
