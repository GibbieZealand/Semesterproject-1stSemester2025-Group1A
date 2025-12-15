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
    /// <summary>
    /// Class for Constructing and calling Maintenance Repository Objects using the interface
    /// </summary>
    public class MaintenanceRepository : IMaintenanceRepository
    {
        #region Instance fields
        private List<IMaintenance> _maintenanceTasks;
        #endregion

        #region Constructor
        public MaintenanceRepository()
        {
            _maintenanceTasks = [];
        }

        #endregion

        #region Methods
        /// <summary>
        /// Adds a maintenance object to the list
        /// </summary>
        /// <param name="maintenance"></param>
        public void AddMaintenance(IMaintenance maintenance)
        {
            _maintenanceTasks.Add(maintenance);
        }

        /// <summary>
        /// Removes a maintenance object by Id 
        /// </summary>
        /// <param name="id"></param>
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


        /// <summary>
        /// Prints all maintenance objects in the list 
        /// </summary>
        public void PrintAll()
        {
            foreach(IMaintenance m in _maintenanceTasks)
            {
                Console.WriteLine(m+"\n");
            }
        }

        /// <summary>
        /// Returns a maintenance object by Id 
        /// </summary>
        /// <param name="id"></param>
        public IMaintenance? GetMaintenanceById(int id)
        {
            foreach (IMaintenance m in _maintenanceTasks)
            {
                if(m.Id == id)
                {
                    return m;
                }
            }
            return null;
        }


        /// <summary>
        /// Returns a list of pending maintenance tasks 
        /// </summary>
        public List<IMaintenance> GetPendingMaintenanceTasks()
        {
            List<IMaintenance> pendingList = [];
            foreach(IMaintenance m in _maintenanceTasks)
            {
                if(!m.IsFixed)
                {
                    pendingList.Add(m);
                }
            }
            return pendingList;
        }

        /// <summary>
        /// Returns a list of completed maintenance tasks 
        /// </summary>
        public List<IMaintenance> GetCompletedMaintenanceTasks()
        {
            List<IMaintenance> completedList = [];
            foreach(IMaintenance m in _maintenanceTasks)
            {
                if (m.IsFixed)
                {
                    completedList.Add(m);
                }
            }
            return completedList;
        }


        /// <summary>
        /// Returns the list of all maintenance tasks
        /// </summary>
        public List<IMaintenance> GetAll()
        {
            return _maintenanceTasks;
        }
        #endregion
    }
}
