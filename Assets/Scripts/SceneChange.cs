using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] public string VideoExperience;
    // Start is called before the first frame update
    public void SceneChanger(){
        SceneManager.LoadScene(VideoExperience);
    }

}
