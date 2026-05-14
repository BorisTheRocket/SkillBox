using UnityEngine;

public class Sample : MonoBehaviour
{
  bool myBool = true;
int myInt = 1;
float myFloat = 1.6f;
long myLong = 16L;
ulong myULong = 16UL;
    void Start()
    {
       Debug.Log(myBool); 
       Debug.Log(myInt);
       Debug.Log(myFloat);
       Debug.Log(myLong);
       Debug.Log(myULong);
    }

}
