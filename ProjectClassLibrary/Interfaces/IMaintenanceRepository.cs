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
    public interface IMaintenanceRepository
    {
         
        void AddMaintenance(Maintenance maintenance);
        void RemoveMaintenance(int id);
        void PrintAll();
        Maintenance GetMaintenanceById(int id);
        List<Maintenance> GetPendingMaintenanceTasks();
        List<Maintenance> GetCompletedMaintenanceTasks();
        List<Maintenance> GetAll();
        
        
    }
}
