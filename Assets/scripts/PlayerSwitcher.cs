using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitcher : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    private GameObject activePlayer;

    void Start()
    {
        activePlayer = player1; // Set player1 as the starting active player
        player2.GetComponent<PlayerController>().enabled = false; // Disable player2's movement script
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { // Check if the Space key is pressed
            if (activePlayer == player1)
            { // If the active player is player1, switch to player2
                player1.GetComponent<PlayerController>().enabled = false; // Disable player1's movement script
                player2.GetComponent<PlayerController>().enabled = true; // Enable player2's movement script
                activePlayer = player2; // Set player2 as the new active player
            }
            else
            { // If the active player is player2, switch to player1
                player2.GetComponent<PlayerController>().enabled = false; // Disable player2's movement script
                player1.GetComponent<PlayerController>().enabled = true; // Enable player1's movement script
                activePlayer = player1; // Set player1 as the new active player
            }
        }
    }
}