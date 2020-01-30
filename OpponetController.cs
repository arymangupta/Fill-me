using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class OpponetController : MonoBehaviour
{

    public float fillRate = 0.25f;

    private SpriteRenderer my2DSpriteRenderer;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Init()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        my2DSpriteRenderer = GetComponent<SpriteRenderer>();
        my2DSpriteRenderer.color = Color.white; /* Default color is white*/
    }

    void HealthToColor()
     {
       my2DSpriteRenderer.color =   Color.Lerp(my2DSpriteRenderer.color , player.GetComponent<SpriteRenderer>().color , fillRate);
    }

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.tag.Equals("Bullet")) {
            HealthToColor();
            GameObject.Destroy(collider.gameObject);
            PlayAnimation();
        }

    }
    /*
     * Add parameter switch on what type of animation you want to play
     */
    void PlayAnimation(){

    }

    public void ResetColor(){
        my2DSpriteRenderer.color = Color.white;
    }
}
