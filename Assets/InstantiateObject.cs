using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject robot;

    void Start()
    {
        Instantiate(robot);


    }
        // Update is called once per frame
        void Update()
        {

        }
    }
