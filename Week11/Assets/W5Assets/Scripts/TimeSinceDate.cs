using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeSinceDate : MonoBehaviour {
  public string startingDate;
  public DateTime date;
  private TextMeshPro tmp;
  private TimeSpan diff;

  void Start () {
    tmp = GetComponent <TextMeshPro> ();
    if (startingDate != null) {
      try {
        date = DateTime.Parse (startingDate);
      } catch {
        Debug.LogWarning ("Starting date is invalid. Make sure you have formatted it correctly.");
        SetDateToNow ();
      }
    } else {
      SetDateToNow ();
    }
  }

  void Update () {
    diff = DateTime.Now - date;
    tmp.text = Mathf.Floor (diff.Days / 365) + ":" + (diff.Days % 365) + ":" + diff.Hours + ":" + diff.Minutes + ":" + diff.Seconds + "." + diff.Milliseconds;
  }

  [ContextMenu ("Set Date To Now")]
  void SetDateToNow () {
    date = DateTime.Now;
  }
}
