using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public string message = "âΩÇ©óéÇøÇƒÇ¢ÇÈÅB";

    private bool playerNear = false;
    private bool showMessage = false;

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E))
        {
            showMessage = true;
        }

        if (showMessage && Input.GetKeyDown(KeyCode.Space))
        {
            showMessage = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
            showMessage = false;
        }
    }

    void OnGUI()
    {
        GUIStyle style = new GUIStyle(GUI.skin.label);
        style.fontSize = 24;

        GUIStyle boxStyle = new GUIStyle(GUI.skin.box);
        boxStyle.fontSize = 24;

        if (playerNear && !showMessage)
        {
            GUI.Label(
                new Rect(20, Screen.height - 60, 300, 40),
                "EÅFí≤Ç◊ÇÈ",
                style
            );
        }

        if (showMessage)
        {
            GUI.Box(
                new Rect(20, Screen.height - 120, Screen.width - 40, 80),
                message,
                boxStyle
            );
        }
    }
}