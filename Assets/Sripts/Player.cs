using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ePlayer{
    Left,
    Right
}
public class Player : MonoBehaviour
{

       public float speed = 15f;
       public ePlayer player;
     void Update() {
        float inputSpeed =30f;
        if(player == ePlayer.Left)
        {
            inputSpeed= Input.GetAxisRaw("PlayerLeft");
        }
        else if (player == ePlayer.Right)
        {
            inputSpeed =Input.GetAxisRaw("PlayerRight");
        }
        transform.position += new Vector3(0f, 0f, inputSpeed * speed* Time.deltaTime);
       
        
        
       }
    }
