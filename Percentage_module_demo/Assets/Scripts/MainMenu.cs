using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject mainmenu;
    [SerializeField] GameObject objectives;
    [SerializeField] GameObject learn01;
    [SerializeField] GameObject learn02;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectObjectives()
    {
        mainmenu.SetActive(false);
        objectives.SetActive(true);
    }

    public void selectLearn()
    {
        mainmenu.SetActive(false);
        learn01.SetActive(true);
    }

    public void selectAssess()
    {
        SceneManager.LoadScene(1);
    }

    public void Back00()
    {
        mainmenu.SetActive(true);
        objectives.SetActive(false);
        //learn01.SetActive(false);
    }
    public void Back01()
    {
        mainmenu.SetActive(true);
        //objectives.SetActive(false);
        learn01.SetActive(false);
    }
    public void Back02()
    {
        learn01.SetActive(true);
        learn02.SetActive(false);
    }
    public void Next()
    {
        learn01.SetActive(false);
        learn02.SetActive(true);
    }

}
