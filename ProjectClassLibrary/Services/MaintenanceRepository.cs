using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--Lavet af Necati--
namespace ProjectClassLibrary.Services
{
    public class MaintenanceRepository : IMaintenanceRepository
    {
        #region Instance fields
        private List<Maintenance> _maintenanceTasks;
        #endregion

        #region Constructor
        public MaintenanceRepository()
        {
            _maintenanceTasks = [];
        }

        #endregion

        #region Methods
        // Adds a maintenance object to the list
        public void AddMaintenance(Maintenance maintenance)
        {
            _maintenanceTasks.Add(maintenance);
        }
        // Removes a maintenance object by Id 
        public void RemoveMaintenance(int id)
        {
            for(int i=0; i <= _maintenanceTasks.Count - 1; i++)
            {
                if (_maintenanceTasks[i].Id == id)
                {
                    _maintenanceTasks.RemoveAt(i);
                    return;
                }
            }
        }

        // Prints all maintenance objects in the list 
        public void PrintAll()
        {
            foreach(Maintenance m in _maintenanceTasks)
            {
                Console.WriteLine(m+"\n");
            }
        }
        
        // Returns a maintenance object by Id 
        public Maintenance GetMaintenanceById(int id)
        {
            foreach (Maintenance m in _maintenanceTasks)
            {
                if(m.Id == id)
                {
                    return m;
                }
            }
            return null;
        }


        // Returns a list of pending maintenance tasks 
        public List<Maintenance> GetPendingMaintenanceTasks()
        {
            List<Maintenance> pendingList = [];
            foreach(Maintenance m in _maintenanceTasks)
            {
                if(!m.IsFixed)
                {
                    pendingList.Add(m);
                }
            }
            return pendingList;
        }

        // Returns a list of completed maintenance tasks 
        public List<Maintenance> GetCompletedMaintenanceTasks()
        {
            List<Maintenance> completedList = [];
            foreach(Maintenance m in _maintenanceTasks)
            {
                if (m.IsFixed)
                {
                    completedList.Add(m);
                }
            }
            return completedList;
        }

        // Returns the list of all maintenance tasks 
        public List<Maintenance> GetAll()
        {
            return _maintenanceTasks;
        }
        #endregion
    }
}
