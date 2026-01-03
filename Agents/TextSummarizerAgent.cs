using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Agents;
using System.Threading.Tasks;

namespace BlazorTaskAgent.Agents
{
    public class TextSummarizerAgent
    {
        private readonly Kernel _kernel;

        public TextSummarizerAgent(Kernel kernel)
        {
            _kernel = kernel;
        }

        public async Task<string> SummarizeAsync(string text)
        {
            var prompt = $"""
            Summarize the following text in simple and clear English:

            {text}
            """;

            var result = await _kernel.InvokePromptAsync(prompt);
            return result.GetValue<string>();
        }
    }
}