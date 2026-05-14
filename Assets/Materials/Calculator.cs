using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField] private InputField inputField1;
    [SerializeField] private InputField inputField2;
    [SerializeField] private Text resultText;
    
    private string operation;

    public void Add()      { operation = "+"; }
    public void Subtract() { operation = "-"; }
    public void Multiply() { operation = "*"; }
    public void Divide()   { operation = "/"; }

    public void Calculate()
    {
        float a = float.Parse(inputField1.text);
        float b = float.Parse(inputField2.text);

        if (operation == "+") resultText.text = "" + (a + b);
        if (operation == "-") resultText.text = "" + (a - b);
        if (operation == "*") resultText.text = "" + (a * b);
        if (operation == "/") resultText.text = "" + (a / b);
    }
}