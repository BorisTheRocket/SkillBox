using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ButtonScript : MonoBehaviour
{
    public Text counter;
    public TMP_InputField inputField;
    int a = 0;
    private void Start()
    {
        counter.text = "0";
    }
  public void OnButtonClick()
    {
        //Debug.Log(++a);
        
        counter.text = (++a).ToString();
    }
    public void readText()
    {
        if(inputField.text == "")
        {
            counter.text = "Enter the text";
        }
        else
        {
            counter.text = inputField.text;
        }   
    }
}
