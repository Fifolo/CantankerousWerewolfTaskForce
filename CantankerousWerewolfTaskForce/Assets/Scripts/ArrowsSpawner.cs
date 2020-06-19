using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ArrowsSpawner : MonoBehaviour
{
    public GameObject arrow;

    private Vector3 position = new Vector3(-234,26,0);
    private int objects = 0;
    private bool canSpawn = true;

    private List<GameObject> arrows = new List<GameObject>();

    private GameObject myArrow;

    public void createArrowLeft()
    {
        if (canSpawn)
        {
            myArrow = Instantiate(arrow, position, Quaternion.Euler(0, 0, 270));
            myArrow.transform.SetParent(GameObject.FindGameObjectWithTag("ArrowSpawner").transform, false);
            arrows.Insert(objects, myArrow);
            objects++;
            position += new Vector3(52, 0, 0);
            checkPosition();
        }
    }
    public void createArrowRight()
    {
        if (canSpawn)
        {
            myArrow = Instantiate(arrow, position, Quaternion.Euler(0, 0, 90));
            myArrow.transform.SetParent(GameObject.FindGameObjectWithTag("ArrowSpawner").transform, false);
            arrows.Insert(objects, myArrow);
            objects++;
            position += new Vector3(52, 0, 0);
            checkPosition();
        }
    }
    public void createArrowUp()
    {
        if (canSpawn)
        {
            myArrow = Instantiate(arrow, position, Quaternion.Euler(0, 0, 180));
            myArrow.transform.SetParent(GameObject.FindGameObjectWithTag("ArrowSpawner").transform, false);
            arrows.Insert(objects, myArrow);
            objects++;
            position += new Vector3(52, 0, 0);
            checkPosition();
        }
    }
    public void createArrowDown()
    {
        if (canSpawn)
        {
            myArrow = Instantiate(arrow, position, Quaternion.Euler(0, 0, 0));
            myArrow.transform.SetParent(GameObject.FindGameObjectWithTag("ArrowSpawner").transform, false);
            arrows.Insert(objects, myArrow);
            objects++;
            position += new Vector3(52, 0, 0);
            checkPosition();
        }
    }
    private void checkPosition()
    {
        if (objects == 10)
        {
            position = new Vector3(-234, -26, 0);
        }
        if (objects == 20) canSpawn = false;
    }

    public void deleteLastArrow()
    {
        if (objects>0)
        {
            Destroy(arrows[objects-1]);
            objects--;
            if (objects == 9)
            {
                position = new Vector3(-234 + (9 * 52), 26, 0);
            }
            else
            {
                position += new Vector3(-52, 0, 0);
            }
        }
    }
}
