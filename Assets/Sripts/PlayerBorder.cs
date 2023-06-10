using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBorder : MonoBehaviour
{
    public ePlayer player;
    public AudioSource bizil;
    public scoreUI score;
    void OnCollisionEnter(Collision col) {
    
    ballmove ball = col.gameObject.GetComponent<ballmove>();
    if(ball != null){
        ball.transform.position= new Vector3(0f,1f,0f);

        if (player == ePlayer.Right) score.scorePlayerLeft++;
        {
           
            bizil.Play();
            if(score.scorePlayerLeft==10)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
            }
        }
        if (player == ePlayer.Left) score.scorePlayerRight++;
        {
         bizil.Play();
          if(score.scorePlayerRight==10)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
            }
        }
    }
   }
}
