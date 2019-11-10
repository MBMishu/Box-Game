using UnityEngine;

public class playerCollation : MonoBehaviour
{
  public playerMove playerMove ;
    
    void OnCollisionEnter (Collision collisionInfo) 
    {

        //Debug.Log(collisionInfo.collider.name);

        if (collisionInfo.collider.CompareTag("obstacle"))
        {
           // playerMove = GetComponent<playerMove>();
             playerMove.enabled = false;
           // GetComponent<playerMove>().enabled = false;
            FindObjectOfType<GameManagerScript>().EndGame();

        }
       
    } 
}

