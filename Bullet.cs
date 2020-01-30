using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Bullet : MonoBehaviour
{
    public float moveSpeed = 5f;

    private bool ismoving = false;
    private SpriteRenderer my2DspriteRenderer;
    // Start is called before the first frame update
    void Awake()
    {
       my2DspriteRenderer = GetComponent<SpriteRenderer>();
       ismoving = false;
    }

    // Update is called once per frame
    void Update()
    {
             MoveBullet();
    }

    void MoveBullet(){
        if(!ismoving) return;

        transform.Translate(Vector2.up*moveSpeed*Time.deltaTime);
    }

    /*
     * Set Bullet sprite and color and other things.
     */
    public void SetBulletProperties(Color color) {
        my2DspriteRenderer.color = color;
        ismoving = true;
    }

    /*
     * Call the destroy animation here
     */
    void OnDestroy(){

    }
}
