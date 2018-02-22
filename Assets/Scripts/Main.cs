using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour {

    static public Main S;
    public GameObject[] prefabEnemies;
    public float enemySpawnPerSecond = 1f;
    public float enemyDefaultPadding = 1.5f;
    private BoundsCheck bndCheck;

    void Awake()
    {
        S = this;
        bndCheck = GetComponent<BoundsCheck>();
        
    }
	// Use this for initialization
	void Start () {
		
	}
	
    
	// Update is called once per frame
	void Update () {
		
	}
}
