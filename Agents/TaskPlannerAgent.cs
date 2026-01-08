using System.Threading.Tasks;
using Microsoft.Agents.AI;      // New Framework
using Microsoft.Extensions.AI;  // For IChatClient

// Ensure this namespace matches what you added in _Imports.razor
namespace BlazorTaskAgent.Agents 
{
    public class TaskPlannerAgent
    {
        private readonly AIAgent _agent;

        public TaskPlannerAgent(IChatClient chatClient)
        {
            // We use ChatClientAgent (the wrapper for Ollama/OpenAI clients)
            // Note: Name and Instructions are passed in the constructor now
            _agent = new ChatClientAgent(
                chatClient, 
                "You are a task planning expert. Analyze tasks, assign priority, and suggest deadlines.",
                "TaskPlanner"
            );
        }

        public async Task<string> AnalyzeTaskAsync(string userTask)
        {
            string finalResult = "";

            // Use RunStreamingAsync to receive the response
            await foreach (var update in _agent.RunStreamingAsync(userTask))
            {
                if (!string.IsNullOrEmpty(update.Text))
                {
                    finalResult += update.Text;
                }
            }

            return finalResult;
        }
    }
}