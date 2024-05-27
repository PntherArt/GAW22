using System;
using System.IO; //< system in/out is required for reading and writing JSON files
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReadAndWriteJSON : MonoBehaviour {
  public SaveData barry;

  [Space (20)]
  [Tooltip ("File is saved as .json, do not include any type suffixes in file name")]
  public string fileName;

  [Tooltip ("The datapath is where the executable or app's data folder is stored and is easily accessible by the user.")]
  [TextArea] public string dataPath;

  [Tooltip ("The persistentDataPath is usually a hidden folder called AppData.")]
  [TextArea] public string persistentDataPath;

  [Tooltip ("If true, the game will try to save before quitting.")]
  public bool saveOnQuit = true;
  [Tooltip ("If true, JsonUtility will prettyPrint the save file.")]
  public bool pretty = false;

  [Space (20)]
  public TextMeshPro importantTMP;
  public TextMeshPro  dateTimeComparisonTMP;
  public Transform trackedTransform;
  public string[] someStrings;
  public List<Vector3> vectors;
  public SaveData.Mood mood;
  public Color color;

  [ContextMenu ("Load")]
  public void LoadGame () {
    dataPath = Application.dataPath + "/" + fileName + ".json";
    persistentDataPath = Application.persistentDataPath + "/" + fileName + ".json";

    string contents;
    try {
      contents = System.IO.File.ReadAllText (dataPath);
      JsonUtility.FromJsonOverwrite (contents, barry);
      /*
      you can also access json info using the FromJson function, which stores a copy of the returned file in memory rather than assigning it to a variable immediately. sometimes useful. written like so:
      barry = JsonUtility.FromJson <SaveData> (contents);
      */
    } catch {
      try {
        contents = System.IO.File.ReadAllText (persistentDataPath);
        JsonUtility.FromJsonOverwrite (contents, barry);
      } catch (Exception e) {
        Debug.LogException (e);
      }
    }
  }

  [ContextMenu ("Save")]
  public void SaveGame () {
    barry.dateTime = DateTime.Now.ToString ();
    barry.importantText = importantTMP.text;
    barry.position = trackedTransform.position;
    barry.rotation = trackedTransform.eulerAngles;
    barry.bunchaStrings = someStrings;
    barry.vectors = vectors;
    barry.mood = mood;
    barry.color = color;

    WriteSaveFileToJSON ();
  }


  public void WriteSaveFileToJSON () {
    string contents = JsonUtility.ToJson (barry, pretty);

    try {
      // print ("attempting to save to primary filepath");
      System.IO.File.WriteAllText (dataPath, contents);
      // print ("file saved at primary filepath");
    } catch (Exception e0) {
      Debug.LogException (e0);
      // print ("cannot save to primary filepath. attempting to save to secondary filepath");
      try {
        System.IO.File.WriteAllText(persistentDataPath, contents);
        // print ("file saved at secondary filepath");
      } catch (Exception e1) {
        Debug.Log (e1);
        // print ("cannot save to either filepath");
      }
    }
  }

  [ContextMenu ("Reset Saved Data")]
  public void ResetSaveData () {
    barry.dateTime = "";
    barry.importantText = "";
    barry.position = Vector3.zero;
    barry.rotation = Vector3.zero;
    barry.bunchaStrings = null;
    barry.vectors = null;
    barry.mood = 0;
    barry.color = Color.black;

    WriteSaveFileToJSON ();
  }

  [ContextMenu ("Apply Saved Data")]
  public void ApplySavedData () {
    try {
      dateTimeComparisonTMP.text = "time since last played: " + (DateTime.Now - DateTime.Parse (barry.dateTime));
    } catch {
      print ("saved DateTime invalid. Cannot parse.");
      dateTimeComparisonTMP.text = "[Invalid DateTime]";
    }
    importantTMP.text =  barry.importantText;

    trackedTransform.position = barry.position;
    trackedTransform.eulerAngles = barry.rotation;

    someStrings = barry.bunchaStrings;
    vectors = barry.vectors;
    mood = barry.mood;
    color = barry.color;
  }

  void OnApplicationQuit () {
    if (saveOnQuit) {
      SaveGame ();
    }
  }
}
