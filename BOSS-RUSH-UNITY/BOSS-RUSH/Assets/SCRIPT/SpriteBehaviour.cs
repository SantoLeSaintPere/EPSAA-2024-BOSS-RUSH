using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

[ExecuteInEditMode]
public class SpriteBehaviour : MonoBehaviour
{
    public Material spriteMat;
    SpriteRenderer spriteRenderer;
    public bool needRot;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.material = spriteMat;
        spriteRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.TwoSided;
        spriteRenderer.receiveShadows = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(!needRot)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}