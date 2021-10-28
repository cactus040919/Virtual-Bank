using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Collections;

public class CharacterMove : MonoBehaviour
{
    int PlayerSpeed = 5;
    float xMove, yMove;

    void Update()
    {
        xMove = 0;
        yMove = 0;

        if (Input.GetKey(KeyCode.RightArrow))
            xMove = PlayerSpeed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.LeftArrow))
            xMove = -PlayerSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow))
            yMove = PlayerSpeed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.DownArrow))
            yMove = -PlayerSpeed * Time.deltaTime;
        this.transform.Translate(new Vector3(xMove, yMove, 0));
    }
}
