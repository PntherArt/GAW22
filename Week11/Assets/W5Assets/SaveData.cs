using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //class must be serialized in order to be read/written
public class SaveData {
  //certain data types cannot be implicitly serialized (such as dates, transforms, cameras, and other complex types) and must be stored in other forms or in structs which can be converted back to their original types. check JsonUtility API for more details: https://docs.unity3d.com/ScriptReference/JsonUtility.html
  public string dateTime;
  [TextArea] public string importantText;
  public Vector3 position, rotation;
  public string[] bunchaStrings;
  public List<Vector3> vectors;
  public Mood mood;
  public Color color;

  public enum Mood {
    Neutral, Happy, Sad, Hopeful, Bored, Angry
  }
}
