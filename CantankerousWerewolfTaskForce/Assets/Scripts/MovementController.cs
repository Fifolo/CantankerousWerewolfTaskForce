using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float speed = 5f;


    private List<string> movement = new List<string>();
    private Vector3 currentPosition;
       
    private void Start()
    {
        //get current position
        currentPosition = transform.position;
    }


    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, currentPosition, speed * Time.fixedDeltaTime);
    }

    public void movePlayer()
    {
        foreach (string direction in movement)
        {
            {
                switch (direction)
                {
                    case "LEFT":
                        transform.position = Vector3.Lerp(currentPosition, currentPosition + Vector3.left, speed * Time.fixedDeltaTime);
                        currentPosition += Vector3.left;
                        break;

                    case "RIGHT":
                        transform.position = Vector3.Lerp(currentPosition, currentPosition + Vector3.right, speed * Time.fixedDeltaTime);
                        currentPosition += Vector3.right;
                        break;

                    case "UP":
                        transform.position = Vector3.Lerp(currentPosition, currentPosition + Vector3.up, speed * Time.fixedDeltaTime);
                        currentPosition += Vector3.up;
                        break;

                    case "DOWN":
                        transform.position = Vector3.Lerp(currentPosition, currentPosition + Vector3.down, speed * Time.fixedDeltaTime);
                        currentPosition += Vector3.down;
                        break;
                }
            }
        }
    }

    public void removeLast()
    {
        if(movement[movement.Count-1] != null)
        movement.RemoveAt(movement.Count-1);
    }
    public void moveLeft()
    {
        movement.Add("LEFT");
    }
    public void moveRight()
    {
        movement.Add("RIGHT");
    }
    public void moveUp()
    {
        movement.Add("UP");
    }
    public void moveDown()
    {
        movement.Add("DOWN");
    }
}
