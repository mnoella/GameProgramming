using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Spawn : MonoBehaviour
{
    public SpawnerManager spawnerManager;
    public float dist = 100f;
    //public TextMeshProUGUI gameOverText;
    

    // Start is called before the first frame update
    void Start()
    {   
        spawnerManager = GameObject.Find("SpawnerManager").GetComponent<SpawnerManager>();
        //gameOverText.gameObject.SetActive(false);
        //restartButton.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {   
        
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(spawnerManager.objectToSpawn, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + dist), Quaternion.identity);
        }

        
        // if (collision.gameObject.tag == "Obstacle")
        // {
        //     gameOverText.gameObject.SetActive(true);
            
        //     Time.timeScale = 0f;
        // }
    }

}
