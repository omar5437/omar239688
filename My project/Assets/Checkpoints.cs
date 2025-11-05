using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{ 
    // Called automatically when another collider enters this trigger collider
     // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Update the current checkpoint in the LevelManager to this checkpoint game object
            FindObjectOfType<LevelManager>().CurrentCheckpoint = this.gameObject;

            // Optional: print message to console to confirm checkpoint activation
            Debug.Log("Checkpoint reached: " + this.gameObject.name);
        }
    }
}
