using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

    public GameObject dummyObj;
    public TextMeshProUGUI buttonText;
    bool onoffState;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dummyObj.SetActive(false);
        onoffState = false;
        buttonText.text = "MENU";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartTheGame() 
    {
        onoffState = !onoffState; // toggles false and true
        Debug.Log("TEST BUTTON"); // create output in console
        // dummyObj.localScale = new Vector3(2f,2f,2f);
        dummyObj.SetActive(onoffState);

        if (onoffState == true) {
            buttonText.text = "True";
        }
        if (onoffState == false) {
            buttonText.text = "False";
        }
    }

    public void LoadNewScene() 
    {
        SceneManager.LoadScene("NewScene");
        // SceneManager.LoadScene(1);
    }
}
