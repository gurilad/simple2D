using UnityEngine.SceneManagement;
using UnityEngine;

public class playagain : MonoBehaviour
{
    public void OnClick(){
        SceneManager.LoadScene("game");
    }
}
