using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NexLevel : MonoBehaviour
{
    public int sceneBuildIndex;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("IM TOUCHING");
        if(other.tag == "Player")
        {
            
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
        
    }

}
