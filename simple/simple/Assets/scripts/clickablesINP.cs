
using UnityEngine;
using TMPro;
public class clickablesINP : MonoBehaviour
{
    

    public main main;
    
    void Update(){

        main = GameObject.Find("spawner").GetComponent<main>();
        main.cubesAMT = System.Convert.ToInt32(this.gameObject.GetComponent<TMP_InputField>().text);
    }
}
