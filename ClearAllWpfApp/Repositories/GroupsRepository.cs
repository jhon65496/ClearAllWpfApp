using System.Linq;
using SimpleExampleWpfApp.Models;
using SimpleExampleWpfApp.Services.Base;
using SimpleExampleWpfApp.Data;


namespace SimpleExampleWpfApp.Repositories
{
    class GroupsRepository : RepositoryInMemory<Group>
    {
        public GroupsRepository() : base(TestData.Groups) { }

        public Group Get(string GroupName) => GetAll().FirstOrDefault(g => g.Name == GroupName);

        public new void Clear() => base.Clear();

        protected override void Update(Group Source, Group Destination)
        {
            Destination.Name = Source.Name;
            Destination.Description = Source.Description;
        }
    }
}