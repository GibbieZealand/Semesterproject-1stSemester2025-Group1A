using ProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--Lavet af Necati--
namespace ProjectClassLibrary.Interfaces
{
    /// <summary>
    /// Interface for the MaintenanceRepository class
    /// </summary>
    public interface IMaintenanceRepository
    {
         
        void AddMaintenance(IMaintenance maintenance);
        void RemoveMaintenance(int id);
        void PrintAll();
        IMaintenance GetMaintenanceById(int id);
        List<IMaintenance> GetPendingMaintenanceTasks();
        List<IMaintenance> GetCompletedMaintenanceTasks();
        List<IMaintenance> GetAll();
        
        
    }
}
