using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pizza : MonoBehaviour
{
    // Start is called before the first frame update
    float EnteredSlices;
    [SerializeField] Text pizzaValue;
    [SerializeField] Slider pizzaSlider;
    [SerializeField] Text selectedSlices;
    //[SerializeField] Text TotalSlices;
    float totalslices = 10;
    [SerializeField] Text percentage;
    [SerializeField] Image pizzaTint;
    [SerializeField] Image BarTint;
    [SerializeField] Image PieTint;

    [SerializeField] Text barpercent;
    [SerializeField] Text piepercent;
    void Start()
    {
        totalslices = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePizzaSlider()
    {
        pizzaValue.text = Mathf.RoundToInt(pizzaSlider.value).ToString();
        selectedSlices.text= Mathf.RoundToInt(pizzaSlider.value).ToString();
        float percent = ((pizzaSlider.value) / totalslices)*100;
        percentage.text = percent.ToString()+"%";
        pizzaTint.fillAmount = pizzaSlider.value / 10;
        PieTint.fillAmount = pizzaSlider.value / 10;
        BarTint.fillAmount = pizzaSlider.value / 10;
        barpercent.text = percent.ToString() + "%";
        piepercent.text = percent.ToString() + "%";
    }

    public void OnNext()
    {
        SceneManager.LoadScene(2);
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene(0);
    }
}
