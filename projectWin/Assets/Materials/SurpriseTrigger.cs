using UnityEngine;
using System.Collections;

public class SurpriseTrigger : MonoBehaviour {

    public GameObject sphere;
    public Material skybox;
    public Light sun;


    ArrayList spheres;

    bool hasEntered = false;


	// Use this for initialization
	void Start () {

        spheres = new ArrayList();

        for (int i = 0; i < 25; i++) {

            spheres.Add(sphere);
        
        
        }
	
	}

    void OnTriggerEnter() { 
    
    
   if (hasEntered == false){
       showSurprise();
       hasEntered = true;
    
    
    
    
    }
    
    
    }

    void showSurprise() {

        foreach (GameObject s in spheres) { 
        
        float x = Random.Range(-100, 100);
            float y = Random.Range(25,50);
             float z = Random.Range(-100,100);

             s.transform.position = new Vector3(x,y,z);
             Instantiate(s);
             RenderSettings.skybox = skybox;
             sun.intensity = 1;
        
        }
    
    
    
    }
}
