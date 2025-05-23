using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceContoller : MonoBehaviour
{
    public void onBoarding1(){
        SceneManager.LoadScene("onBoarding1");
    }

    public void IndoorNavigation1(){
        SceneManager.LoadScene("IndoorNavigation1");
    }
}
