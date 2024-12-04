using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
    public Animator transitionFade;
    public float waitTime = 1f;
    // Update is called once per frame
    void Update()
    {
        //if the player triggers the ladder object
        //openMenu();
    }

    public void openMenu()
    {
        StartCoroutine(MenuAnimation());
    }

    IEnumerator MenuAnimation()
    {
        //start animation
        transitionFade.SetTrigger("start"); //animation trigger in animator to start animation
        //wait for animation to play
        yield return new WaitForSeconds(waitTime);
        //load scene
        SceneManager.LoadScene("MenuScene");
    }
}
