using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpwaner tankSpwaner;
    public void BlueTankSelected()
    {
        Debug.Log("Blue Tank Selected");
        tankSpwaner.CreateTank(TankTypes.BlueTank);
    }
    public void GreenTankSelected()
    {
        tankSpwaner.CreateTank(TankTypes.GreenTank);
    }
  
    public void RedTankSelected()
    {
        tankSpwaner.CreateTank(TankTypes.RedTank);
    }

}
