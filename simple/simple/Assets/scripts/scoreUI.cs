
using UnityEngine;
using TMPro;

public class scoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public main main;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + main.score.ToString();
    }
}
