using System.Threading.Tasks;
using Microsoft.Agents.AI;      // New Agent Framework
using Microsoft.Extensions.AI;  // For IChatClient

namespace BlazorTaskAgent.Agents
{
    public class TextSummarizerAgent
    {
        private readonly AIAgent _agent;

        // FIX: The constructor must ask for 'IChatClient', NOT 'Kernel'
        public TextSummarizerAgent(IChatClient chatClient)
        {
            _agent = new ChatClientAgent(
                chatClient,
                "You are a text summarization expert. Summarize the given text concisely into 3-5 bullet points.",
                "TextSummarizer"
            );
        }

        public async Task<string> SummarizeAsync(string userText)
        {
            string finalResult = "";

            // The new framework uses 'RunStreamingAsync'
            await foreach (var update in _agent.RunStreamingAsync(userText))
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