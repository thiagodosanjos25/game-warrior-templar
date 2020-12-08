using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
public void IniciarJogo()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void TerminarJogo()
    {
        Application.Quit();
    }

    public void ParaMenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
