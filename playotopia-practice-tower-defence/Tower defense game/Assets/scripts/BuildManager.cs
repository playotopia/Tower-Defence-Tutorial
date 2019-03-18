using UnityEngine;


public class BuildManager : MonoBehaviour {

    public static BuildManager instance;
    void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More than one BuildManager in Scene.");
            return;
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject misselLauncherPrefab;

    public GameObject buildEffect;

    private TorretBlueprint turretTobuild;
    public bool Canbuild { get { return turretTobuild != null;  } }
    public bool HasMoney { get { return PlayerStats.Money >= turretTobuild.cost; } }

    public void BuildTurretOn(Node node)
    {
        if (PlayerStats.Money < turretTobuild.cost)
        {
            Debug.Log("Not enough money to build that");
            return;
        }

        PlayerStats.Money -= turretTobuild.cost;

        GameObject turret = (GameObject)Instantiate(turretTobuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        GameObject effect = (GameObject) Instantiate(buildEffect, node.GetBuildPosition(), Quaternion.identity);

        Destroy(effect, 5f);

        Debug.Log("Turret Build! Money left: " +PlayerStats.Money);
    }


    public void SelectTurretToBuild(TorretBlueprint turret)
    {
        turretTobuild = turret;
    }
}
