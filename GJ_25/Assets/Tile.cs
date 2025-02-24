using UnityEngine;

public class Tile : MonoBehaviour
{

    public Color hoverColor;
    public Vector3 posOffset;

    private GameObject turret;
    private Renderer rend;
    private Color startColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<Renderer>();//cache this at the start so you dont need to find everytime
        startColor = rend.material.color;
    }

    private void OnHover()
    {
        rend.material.color = hoverColor;
    }
    private void onHoverExit()
    {
        rend.material.color = startColor;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
