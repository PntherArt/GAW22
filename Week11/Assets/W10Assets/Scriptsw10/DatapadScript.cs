using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DatapadScript : MonoBehaviour
{

    public void Start()
    {
        var input = gameObject.GetComponent<TMP_InputField>();
        var se = new TMP_InputField.SubmitEvent();
        se.AddListener(SubmitData);
        input.onEndEdit = se;
    }

    private void SubmitData(string data)
    {
        print(data);
    }
}
