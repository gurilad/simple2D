
using UnityEngine;
using TMPro;
public class namesaver : MonoBehaviour
{
    private GameObject inputFeild;
    private string inText;
    void Awake(){
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        inputFeild = transform.GetChild(0).gameObject;
        inText = inputFeild.GetComponent<TMP_InputField>().text;
    }

    // Update is called once per frame
    
}
