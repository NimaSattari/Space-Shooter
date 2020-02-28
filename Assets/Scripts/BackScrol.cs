using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScrol : MonoBehaviour
{
    [SerializeField] float backgroundScrollSpeed = 0.5f;
    Material material;
    Vector2 offSet;
    
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;
        offSet = new Vector2(0f,backgroundScrollSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        material.mainTextureOffset += offSet * Time.deltaTime;
    }
}
