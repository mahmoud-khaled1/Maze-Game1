using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class EndTrigger : MonoBehaviour
{

    public GameObject te;
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

        te.name = "";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    
}
