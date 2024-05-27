using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadAndWritePlayerPrefs : MonoBehaviour {
  //player preferences are stored in a different place depending on the OS: https://docs.unity3d.com/ScriptReference/PlayerPrefs.html
  public int specialInt;
  public string specialIntKey;

  public float specialFloat;
  public string specialFloatKey;

  public string specialString;
  public string specialStringKey;

  [ContextMenu ("Save Prefs")]
  public void SavePrefs () {
    print ("Saving preferences...");
    PlayerPrefs.SetInt (specialIntKey, specialInt);
    PlayerPrefs.SetFloat (specialFloatKey, specialFloat);
    PlayerPrefs.SetString (specialStringKey, specialString);
    deleteAllPrefs = false;
    print ("Preferences saved.");
  }

  [ContextMenu ("Load Prefs")]
  public void LoadPrefs () {
    print ("Loading preferences...");
    specialInt = PlayerPrefs.GetInt (specialIntKey);
    specialFloat = PlayerPrefs.GetFloat (specialFloatKey);
    specialString = PlayerPrefs.GetString (specialStringKey);
    deleteAllPrefs = false;
    print ("Preferences loaded.");
  }

  [ContextMenu ("Reset Prefs")]
  public void ResetPrefs () {
    print ("Resetting preferences...");
    specialInt = 0;
    specialFloat = 0;
    specialString = "";
    deleteAllPrefs = false;
    print ("Preferences reset.");
  }

  private bool deleteAllPrefs = false;

  [ContextMenu ("Delete All Prefs (Caution!)")]
  public void DeletAllPrefs () {
    if (deleteAllPrefs) {
      print ("Confirmed.");
      PlayerPrefs.DeleteAll ();
      deleteAllPrefs = false;
      print ("All preferences have been deleted.");
    } else {
      Debug.LogWarning ("Caution! This will delete ALL saved preferences. Are you sure you want to do this? (Call this function again to confirm or call 'Cancel Delete All Prefs' to cancel)", this);
      deleteAllPrefs = true;
    }
  }

  [ContextMenu ("Cancel Delete All Prefs")]
  public void CancelDeleteAllPrefs () {
    if (deleteAllPrefs) {
      print ("Cancelled.");
      deleteAllPrefs = false;
      print ("All preferences intact.");
    }
  }
}
