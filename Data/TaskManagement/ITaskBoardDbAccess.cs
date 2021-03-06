using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoNorth.Data.TaskManagement
{
    /// <summary>
    /// Interface for Database Access for Task Boards
    /// </summary>
    public interface ITaskBoardDbAccess
    {
        /// <summary>
        /// Creates a new task board
        /// </summary>
        /// <param name="board">Board to create</param>
        /// <returns>Created board, with filled id</returns>
        Task<TaskBoard> CreateTaskBoard(TaskBoard board);

        /// <summary>
        /// Gets a task board by the id
        /// </summary>
        /// <param name="id">Board Id</param>
        /// <returns>Board</returns>
        Task<TaskBoard> GetTaskBoardById(string id);

        /// <summary>
        /// Returns the open Task Boards for a project
        /// </summary>
        /// <param name="projectId">Project Id</param>
        /// <param name="start">Start of the query</param>
        /// <param name="pageSize">Page Size</param>
        /// <returns>Task Boards</returns>
        Task<List<TaskBoard>> GetOpenTaskBoards(string projectId, int start, int pageSize);

        /// <summary>
        /// Returns the count of open Task Boards for a project
        /// </summary>
        /// <param name="projectId">Project Id</param>
        /// <returns>Task Board Count</returns>
        Task<int> GetOpenTaskBoardCount(string projectId);

        /// <summary>
        /// Returns the closed Task Boards for a project
        /// </summary>
        /// <param name="projectId">Project Id</param>
        /// <param name="start">Start of the query</param>
        /// <param name="pageSize">Page Size</param>
        /// <returns>Task Boards</returns>
        Task<List<TaskBoard>> GetClosedTaskBoards(string projectId, int start, int pageSize);

        /// <summary>
        /// Returns the count of closed Task Boards for a project
        /// </summary>
        /// <param name="projectId">Project Id</param>
        /// <returns>Task Board Count</returns>
        Task<int> GetClosedTaskBoardCount(string projectId);

        /// <summary>
        /// Returns all task boards
        /// </summary>
        /// <returns>All task boards</returns>
        Task<List<TaskBoard>> GetAllTaskBoards();

        /// <summary>
        /// Updates a task board
        /// </summary>
        /// <param name="board">Task Board</param>
        /// <returns>Task</returns>
        Task UpdateTaskBoard(TaskBoard board);

        /// <summary>
        /// Deletes a task board
        /// </summary>
        /// <param name="board">Board</param>
        /// <returns>Task</returns>
        Task DeleteTaskBoard(TaskBoard board);
    }
}