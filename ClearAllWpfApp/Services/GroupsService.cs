using System;
using System.Collections.Generic;
using System.Text;
using SimpleExampleWpfApp.Repositories;
using SimpleExampleWpfApp.Models;

namespace SimpleExampleWpfApp.Services
{
    class GroupsService
    {
        GroupsRepository GroupsRepository;

        public GroupsService()
        {
            GroupsRepository = new GroupsRepository();
        }


        public IEnumerable<Group> GetAll()
        {
            return GroupsRepository.GetAll();
        }


        /// === === === === === === ===
        /// Delete
        ///  === === === === === === ===

        #region Delete
        public void DeleteAll()
        {
            GroupsRepository.Clear();
        }

        #endregion



    }
}
