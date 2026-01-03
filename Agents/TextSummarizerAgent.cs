using System.Threading.Tasks;
using System;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Agents;
using Microsoft.SemanticKernel.ChatCompletion;

namespace BlazorTaskAgent.Agents 
{
    public class TextSummarizerAgent
    {
        private readonly ChatCompletionAgent _agent;

        public TextSummarizerAgent(Kernel kernel)
        {
            _agent = new ChatCompletionAgent
            {
                Name = "Summarizer",
                Instructions = "You are a summarization expert. Read the user's text and provide a concise summary.",
                Kernel = kernel
            };
        }

        public async Task<string> SummarizeAsync(string inputText)
        {
            ChatHistory history = new ChatHistory();
            history.AddUserMessage($"Summarize this text: {inputText}");

            var responseMessages = _agent.InvokeAsync(history);
            string finalResult = "";

            await foreach (var item in responseMessages)
            {
                if (item.Message?.Content != null)
                {
                    finalResult += item.Message.Content + "\n";
                }
            }

            return finalResult;
        }
    }
}