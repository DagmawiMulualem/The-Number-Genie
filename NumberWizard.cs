using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Start is called before the first frame update
    void Start() {
        StartGame(); 
    }
    void StartGame()
    {

        NextGuess();
        
    }
    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }
    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }
    public class ExampleClass : MonoBehaviour
    {

        void Start()
        {
            SceneManager.LoadScene(Random.Range(0, SceneManager.sceneCount));
        }
    }
    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
   
}
