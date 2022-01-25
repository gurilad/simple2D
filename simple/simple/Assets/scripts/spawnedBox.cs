using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnedBox : MonoBehaviour
{
    private GameObject spawner;
    private main main;
    public bool isSpawnable;
    // public int TimeTillDespawn = 10;
    
        // Start is called before the first frame update
    void Start(){
        // StartCoroutine(spawnOBJ());
        isSpawnable = true; 
        spawner = GameObject.Find("spawner");
        main = spawner.GetComponent<main>();
    }
    // IEnumerator spawnOBJ(){
        
    //     yield return new WaitForSeconds(TimeTillDespawn);
    //     main.score--;
    //     isSpawnable = false;
        
    // }
    void OnMouseDown(){
        
        if(isSpawnable){
            
            main.score++;
            Destroy(gameObject);


            isSpawnable = false;
            

            
        }
    }


    // Update is called once per frame
    void Update(){
        if(isSpawnable == false){
            Destroy(gameObject);
        }
    }
}
