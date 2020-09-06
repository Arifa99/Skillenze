using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class ModelGenerate : MonoBehaviour
{
    public GameObject btn;
    public Transform buttonHolder;
    Texture[] imgTexture;

    public GameObject ring;
    // Start is called before the first frame update
    void Start()
    {
        imgTexture = Resources.LoadAll<Texture>("Image");
        foreach(Texture img in imgTexture)
        {
            GameObject ModelButton = Instantiate(btn as GameObject);
            ModelButton.transform.SetParent(buttonHolder);
            ModelButton.GetComponent<RawImage>().texture = img;
            string modelname = img.name;
            //Debug.Log(modelname);
            ModelButton.GetComponent<Button>().onClick.AddListener(() => onModelChange(modelname));

        }

    }

    public void onModelChange(string modelname)
    {
        GameObject go =  null;
        Debug.Log(modelname);
        if(GameObject.FindGameObjectWithTag(modelname)!= null)
        {
            go = GameObject.FindGameObjectWithTag(modelname);
        }
        if(go != null)
        {
            if(!go.activeSelf)
            {
                go.SetActive(true);
                go.transform.position = ring.transform.position;
            }
            else
            {
                go.SetActive(false);
            }
           
        }
    }
}
