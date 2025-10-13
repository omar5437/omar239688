using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed; // how fast the character moves
    public float jumpHeight; // how high the character jumps
    //private bool isFacingRight; // check if player is facing right
    public KeyCode Spacebar; // Jump is the name we gave a keyboard button we chose to be the jump button.
    // In this case, we chose the Space button, and called it Spacebar. To allocate the Space button to the name 
    // Spacebar, go to the Script
    //component of your player character, and choose Space from the dropdown list
    public KeyCode L; // L is the name we gave a keyboard button we chose to be the left movement button.
    public KeyCode R; // R is the name we gave a keyboard button we chose to be the right movement button.


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   // Update is called once per frame
void Update()
{
    if (Input.GetKeyDown(Spacebar)) // When user presses the space button ONCE
    {
        Jump(); // See function definition below
    }

    if (Input.GetKey(L)) // When user presses the left arrow button
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        // Player character moves horizontally to the left along the x-axis without disrupting jump
    }

    if (Input.GetKey(R)) // When user presses the right arrow button
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        // Player character moves horizontally to the right along the x-axis without disrupting jump
    }
if (Input.GetKey(L)) // When user presses the left arrow button
{
    GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
    // Player character moves horizontally to the left along the x-axis without disrupting jump

    if (GetComponent<SpriteRenderer>() != null)
    {
        GetComponent<SpriteRenderer>().flipX = true;
    }
}

if (Input.GetKey(R)) // When user presses the right arrow button
{
    GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
    // Player character moves horizontally to the right along the x-axis without disrupting jump

    if (GetComponent<SpriteRenderer>() != null)
    {
        GetComponent<SpriteRenderer>().flipX = false;
    }






}

void Jump()
{
    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    // Player character jumps vertically along the y-axis without disrupting horizontal walk
}

}
}








