using NUnit.Framework;
using ProjectManagementSystem.Entity;
using ProjectManagementSystem.BusinessLayer.Repository;

namespace ProjectManagementSystem.Test
{
    [TestFixture]
    public class ProjectManagementSystemTest
    {
        private IProjectService _projectRepository;

        [SetUp]
        public void Setup()
        {
            // Initialize the repository implementation with a connection string
            _projectRepository = new ProjectRepositoryImpl("Data Source=DESKTOP-5VEHB15;Initial Catalog=PMSystem;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }

        [Test]
        public void CreateEmployee_EmployeeCreatedSuccessfully_ReturnsTrue()
        {
            var employee = new Employee
            {
                Name = "Meera Desai",
                Designation = "Team Lead",
                Gender = "F",
                Salary = 110000,
                ProjectId = 1
            };

            var result = _projectRepository.CreateEmployee(employee);

            Assert.IsTrue(result, "Employee should be created successfully.");
        }

        [Test]
        public void CreateTask_TaskCreatedSuccessfully_ReturnsTrue()
        {
            var task = new Task
            {
                TaskName = "Develop AI Module",
                ProjectId = 1,
                EmployeeId = 1,
                Status = "Assigned"
            };

            var result = _projectRepository.CreateTask(task);

            Assert.IsTrue(result, "Task should be created successfully.");
        }

        [Test]
        public void GetAllTasksAssignedToEmployee_TasksRetrievedSuccessfully_ReturnsListOfTasks()
        {
            var result = _projectRepository.GetAllTasksAssignedToEmployee(1, 1);

            Assert.IsNotNull(result, "The task list should not be null.");
            Assert.IsTrue(result.Count > 0, "There should be tasks assigned to the employee.");
        }

        [Test]
        public void DeleteEmployee_NonExistentEmployee_ReturnsFalse()
        {
            var result = _projectRepository.DeleteEmployee(999);  // Assuming 999 is a non-existent employee ID.

            Assert.IsFalse(result, "Delete should return false if employee does not exist.");
        }

        [Test]
        public void AssignProjectToEmployee_ProjectAssignedSuccessfully_ReturnsTrue()
        {
            var result = _projectRepository.AssignProjectToEmployee(1, 1);  // Assuming employeeId 1 and projectId 1 exist.

            Assert.IsTrue(result, "Project should be assigned to employee successfully.");
        }

        [Test]
        public void AssignTaskToEmployee_TaskAssignedSuccessfully_ReturnsTrue()
        {
            var result = _projectRepository.AssignTaskToEmployee(1, 1, 1);  // Assuming taskId 1, employeeId 1, and projectId 1 exist.

            Assert.IsTrue(result, "Task should be assigned to employee successfully.");
        }

        [Test]
        public void DeleteProject_ProjectDeletedSuccessfully_ReturnsTrue()
        {
            var result = _projectRepository.DeleteProject(1);  // Assuming projectId 1 exists.

            Assert.IsTrue(result, "Project should be deleted successfully.");
        }
    }
}
