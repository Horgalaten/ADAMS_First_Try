using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class MainClasses
{
    public GameObject cube,cube2;
    public static float color1,color2;
    public static Texture m_MainTexture;
    
    [RuntimeInitializeOnLoadMethod]
 static void OnRuntimeMethodLoad()
        {
            color1 = 0;            
            color2 = 0;
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position += Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2 - (((Screen.width/2)*11)/100), Screen.height/2),0 );
            cube.AddComponent<CubeScript>();
            color1 = Random.Range(0,1.0f);
            Color brown = new Color(0.0f, 0.0f, color1,1.0f);
            Color emission = new Color(0.0f, 0.0f, 0.0f,0.0f);
            cube.GetComponent<Renderer>().sharedMaterial.SetColor("_Color",emission);
            cube.GetComponent<Renderer>().material.SetColor("_EmissionColor",brown);
            cube.name = "cube1";
            Debug.Log(color1);

            GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube2.transform.position += Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height/2),0 );
            
            color2 = Random.Range(0,1.0f);
            cube2.AddComponent<CubeScript>();
            Debug.Log(color2);
            Color purple = new Color(0.0f, 0.0f, color2,1.0f);
            Color emission2 = new Color(0.0f, 0.0f, 0.0f,0.0f);
            cube2.GetComponent<Renderer>().sharedMaterial.SetColor("_Color",emission2);
            
            cube2.name = "cube2";
            
        }



}
