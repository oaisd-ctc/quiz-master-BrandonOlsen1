using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionsSO question;


    void Start()
    {
        questionText.text = question.GetQuestion();
    }

    
   
}
