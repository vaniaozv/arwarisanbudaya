using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void MULAI()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void MENU()
    {
        SceneManager.LoadScene("menu");
    }
    public void PETUNJUK()
    {
        SceneManager.LoadScene("PETUNJUK");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        public void Keluar()
    {
        Application.Quit();
    }
}
