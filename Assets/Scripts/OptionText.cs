using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class OptionText : MonoBehaviour
{
public TextMeshProUGUI output;
    public void HandleInputData(int value)
    {
        if(value == 0){
            output.text = "Option A";
        }
         if(value == 1){
            output.text = "Option B";
        }
         if(value == 2){
            output.text = "Option C";
        }
         if(value == 3){
            output.text = "Option D";
        }
    }

}
