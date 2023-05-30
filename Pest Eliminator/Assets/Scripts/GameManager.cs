using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (  0)
        {
           
        }
    }
}
