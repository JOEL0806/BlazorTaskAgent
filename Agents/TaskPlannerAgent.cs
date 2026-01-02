using System;
using System.Threading.Tasks; 
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Agents;
using Microsoft.SemanticKernel.ChatCompletion;

public class TaskPlannerAgent
{
    private readonly ChatCompletionAgent _agent;

    public TaskPlannerAgent(Kernel kernel)
    {
        _agent = new ChatCompletionAgent
        {
            Name = "TaskPlanner",
            Instructions = "You are a task planning expert. Analyze tasks, assign priority, and suggest deadlines.",
            Kernel = kernel
        };
    }

    public async Task<string> AnalyzeTaskAsync(string userTask)
    {
        ChatHistory history = new ChatHistory();
        history.AddUserMessage($"Please analyze this task: {userTask}");

        var responseMessages = _agent.InvokeAsync(history);

        string finalResult = "";

        // --- THE FIX ---
        await foreach (var item in responseMessages)
        {
            // Use .Message to get the content, not .Item
            if (item.Message?.Content != null)
            {
                finalResult += item.Message.Content + "\n";
            }
        }

        return finalResult;
    }
}