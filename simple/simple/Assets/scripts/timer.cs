using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timeLeft = 30;
    public main main;
   


    void Update()
    {
        if(timeLeft > 0){
            
            timerText.text = "Time Left: " + (int)timeLeft + "s";
            timeLeft -= Time.deltaTime;
        } 
        
    }
    
}
