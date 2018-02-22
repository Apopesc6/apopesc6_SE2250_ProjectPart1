using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 10f;
    public float xSpeed = 10f;

    Vector3 tempPos;
    Vector3 tempPos1;
    private float randomNumber;
    private bool runOnce = true;

    private BoundsCheck bndCheck;

    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
    }

	// Use this for initialization
	void Start () {

        randomNumber = Random.Range(1,2);
        for (int i = 0; i < randomNumber; i++)
        {
            xSpeed = xSpeed * -1;
        }
        

	}
    public Vector3 pos
    {
        get
        {
            return (this.transform.position);
        }
        set
        {
            this.transform.position = value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if(bndCheck != null && bndCheck.offDown)
        {
            Destroy(gameObject);
        }
        if (bndCheck != null && (bndCheck.offRight || bndCheck.offLeft))
        {
            if(runOnce)
            {
                ChangeXDirection();
                runOnce = false;
            }
        }
    }

    void ChangeXDirection()
    {
        xSpeed = xSpeed * -1;
    }

    public virtual void Move()
    {
        if(gameObject.CompareTag("enemy0"))
        {
            tempPos = pos;
            tempPos.y -= speed * Time.deltaTime;
            pos = tempPos;
        }
        if (gameObject.CompareTag("enemy1"))
        {
            tempPos1 = pos;
            tempPos1.y -= speed * Time.deltaTime;
            tempPos1.x -= xSpeed * Time.deltaTime;
            pos = tempPos1;
        }

    }
}
