using UnityEngine;

public class shop : MonoBehaviour {
    public TorretBlueprint standardTorret;
    public TorretBlueprint missileLaauncher;

    BuildManager buildmanager;

    void Start()
    {
        buildmanager = BuildManager.instance;
    }
    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret selected");
        buildmanager.SelectTurretToBuild(standardTorret);
    }
    public void SelectMisselLauncher()
    {
        Debug.Log("Missel Launcher selected");
        buildmanager.SelectTurretToBuild(missileLaauncher);
    }

}
