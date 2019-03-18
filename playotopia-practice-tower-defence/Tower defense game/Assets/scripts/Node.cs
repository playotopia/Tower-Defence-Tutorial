using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Color notEnoughMoneyColor;
    public Vector3 positionOffset;

    [Header ("Optional")]

    public GameObject turret;
    

    private Renderer rend;
    public Color startColor;

    BuildManager buildmanager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildmanager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    } 

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildmanager.Canbuild)
            return;

        if (turret != null)
        {
            Debug.Log("Can't! - TODO: Display on screen.");
            return;
        }
        buildmanager.BuildTurretOn(this);
    }
    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildmanager.Canbuild)
            return;

        if (buildmanager.HasMoney)
        {
            rend.material.color = hoverColor;

        }
        else
        {
            rend.material.color = notEnoughMoneyColor;
        }
    }
    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

}
