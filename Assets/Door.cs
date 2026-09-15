using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string targetScene;
    public Vector2 playerSpawnPosition;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerPrefs.SetFloat("SpawnX", playerSpawnPosition.x);
            PlayerPrefs.SetFloat("SpawnY", playerSpawnPosition.y);

            SceneManager.LoadScene(targetScene);
        }
    }
}