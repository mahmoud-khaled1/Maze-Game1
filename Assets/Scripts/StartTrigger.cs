using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
