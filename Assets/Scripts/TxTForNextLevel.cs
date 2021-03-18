using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxTForNextLevel : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject te; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter()
    {
        
        te.GetComponent<UnityEngine.UI.Text>().text = "congratulations !";
    }
}
