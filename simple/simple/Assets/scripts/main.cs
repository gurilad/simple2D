using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public GameObject clickableObject;
    private GameObject sclickAble;
    public int cubesAMT = 35;
    
    public int score;
    

    Vector2 randLoc(){
        float randomAngle = Random.Range(0f, 6.28319f); //generates random angle in radians
        Vector2 randomVector = new Vector2(Random.Range(-4, 4),Random.Range(-4.9f, 4.9f));
        return randomVector;
    }
    // Update is called once per frame
    
    void Start(){
        for(int i = cubesAMT; i > 0; i--){
            sclickAble = Instantiate(clickableObject, randLoc(), Quaternion.identity);
        }
    }
    
}
