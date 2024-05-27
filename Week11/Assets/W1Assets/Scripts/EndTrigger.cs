using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    
    public GameObject timerScr;
    public GameObject succScr;
    public Animator[] anim;
    public GameObject[] endingAnim;
    public string[] triggerName;
    public AudioSource succSnd;
    public AudioSource popoSnd;
    public AudioSource bgmSnd;

    public GameObject animCnv;

    public void OnTriggerEnter(Collider other)
    {
        timerScr.SetActive(false);
        succScr.SetActive(true);
        succSnd.Play();
        bgmSnd.Stop();

        StartCoroutine(goodEnding());
    }

    IEnumerator goodEnding()
    {
        yield return new WaitForSeconds(5f);
        endingAnim[0].SetActive(false);
        endingAnim[1].SetActive(false);
        endingAnim[3].SetActive(true);
        endingAnim[4].SetActive(true);
        anim[0].SetTrigger(triggerName[0]);
        popoSnd.Play();
        yield return new WaitForSeconds(5f);

        animCnv.SetActive(true);
        anim[1].SetTrigger(triggerName[1]);

        Debug.Log("Game Ended: Good");

    }

}
