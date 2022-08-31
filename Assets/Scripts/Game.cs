using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        // works with scaled game object
        float wallWidth = wall.GetComponent<Renderer>().bounds.size.x;
        float wallHeight = wall.GetComponent<Renderer>().bounds.size.y;

        // center to top times two
        float height = Camera.main.orthographicSize * 2.0f;
        // calculate using screen propotions
        float width = height * Screen.width / Screen.height;

        // starting position
        float x = -width / 2.0f;
        float y = height / 2.0f - wallHeight / 2.0f;

        // make wall at top
        while (x < width / 2.0f)
        {
            Instantiate(wall, new Vector3(x, y, 0), Quaternion.identity);
            x = x + wallWidth;
        }

        // set new starting position
        x = -width / 2.0f;
        y = 0;

        // make row of objects with gap
        while (x < width / 2.0f)
        {
            Instantiate(wall, new Vector3(x, y, 0), Quaternion.identity);
            x = x + 2 * wallWidth;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
