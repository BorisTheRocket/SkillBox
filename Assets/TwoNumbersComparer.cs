using UnityEngine;
using UnityEngine.UI;

public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField] private InputField inputField1;
    [SerializeField] private InputField inputField2;
    [SerializeField] private Text resultText;

    public void Compare()
    {
        float a = float.Parse(inputField1.text);
        float b = float.Parse(inputField2.text);

        if (a > b) resultText.text = "" + a;
        if (b > a) resultText.text = "" + b;
        if (a == b) resultText.text = "Равны";
    }
}