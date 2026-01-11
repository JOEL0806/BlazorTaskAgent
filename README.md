Perfect 👍 I’ll **cleanly update the README content** as requested:

✅ **All screenshot placeholders removed**
✅ **New Ollama AI section added**
✅ Written in a **lecturer-safe, report-aligned academic tone**
✅ Clearly explains **why Ollama is needed, how to install it, and how it is used in the project**

Below is the **UPDATED README.md (final version)**.
You can **replace your existing README entirely** with this.

---

# **BlazorTaskAgent – C# & Microsoft Agent Framework Sample Application**

## **Project Introduction**

**BlazorTaskAgent** is a sample web application developed using **C#**, **Blazor Server**, and the **Microsoft Agent (Semantic Kernel) framework**.
This project is developed for the **TPL6213 – Programming Language Concepts** group assignment to demonstrate how modern programming language concepts are applied in a real-world system.

The application showcases:

* **Agentic AI interaction** using Microsoft Agent framework
* **Web hosting using Blazor Server**
* **Event-driven and asynchronous programming**
* A **Tic-Tac-Toe game** as an interactive sample feature

Through this project, key programming language concepts are demonstrated, including:

* Names and bindings
* Expressions and assignments
* Control structures
* Subprograms (procedures, functions, asynchronous methods)

---

## **Project Objectives**

* To learn and apply **C# programming language concepts**
* To demonstrate the usage of the **Microsoft Agent framework**
* To build a **simple, functional, and interactive sample application**
* To provide explanations supported by **real source code**
* To publish the project as a **web-based research report**

---

## **System Features**

* 🧠 **Task Planner Agent** – processes user tasks using an AI agent
* 🎮 **Tic-Tac-Toe Game** – demonstrates event-driven logic and control structures
* 🌐 **Blazor Web Interface** – component-based user interface
* ⚙️ **Asynchronous Processing** – non-blocking execution using `async/await`

---

## **Technologies Used**

* **Programming Language:** C#
* **Framework:** ASP.NET Core Blazor Server
* **Agent Framework:** Microsoft Semantic Kernel / Agent Framework
* **Local AI Runtime:** Ollama
* **Development Tool:** Microsoft Visual Studio
* **Runtime:** .NET SDK

---

## **Prerequisites (What You Need to Prepare Before Running the Application)**

### **1. .NET SDK**

* **Minimum version:** .NET SDK 8.0
* Download:
  [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

Verify installation:

```bash
dotnet --version
```

---

### **2. Microsoft Visual Studio**

* Version **2022 or later**
* Required workloads:

  * ASP.NET and web development
  * .NET desktop development

Download:
[https://visualstudio.microsoft.com/](https://visualstudio.microsoft.com/)

---

### **3. Ollama (Required for AI Features)**

This project uses **Ollama** as a **local AI model runtime** for agent-based features.
Ollama allows the application to run AI models **locally**, avoiding cloud dependency and API costs.

#### **Download Ollama**

[https://ollama.com/](https://ollama.com/)

#### **Verify Installation**

```bash
ollama --version
```

#### **Download a Supported Model**

Example:

```bash
ollama pull phi3
```

> ⚠️ The AI agent will not function if Ollama or the required model is not installed.

---

### **4. Git (Optional but Recommended)**

Used to clone the repository.

Download:
[https://git-scm.com/downloads](https://git-scm.com/downloads)

---

### **5. Web Browser**

* Microsoft Edge or Google Chrome (latest version)

---

## **How to Get the Sample Application**

### **Option 1: Clone from GitHub**

```bash
git clone https://github.com/JOEL0806/BlazorTaskAgent.git
cd BlazorTaskAgent
```

### **Option 2: Download ZIP**

1. Click **Code → Download ZIP**
2. Extract the folder
3. Open the project in Visual Studio

---

## **How to Run the Application**

### **Using Command Prompt**

```bash
dotnet restore
dotnet run
```

Open your browser:

```
http://localhost:5000
or
https://localhost:5001
```

---

### **Using Visual Studio**

1. Open `BlazorTaskAgent.sln`
2. Click **Run (▶)** or press `F5`
3. The browser will open automatically

---

## **Agent Configuration (Required for AI Features)**

This application uses the **Microsoft Semantic Kernel / Agent framework** together with **Ollama**.

### **Configuration Steps**

1. Open `appsettings.json`
2. Configure the local AI model:

```json
{
  "Ollama": {
    "ModelId": "phi3",
    "Endpoint": "http://localhost:11434"
  }
}
```

3. Save the file
4. Ensure **Ollama is running**
5. Restart the application

⚠️ **Important Note:**
If Ollama or the specified model is not available, agent-related features may fail at runtime.

---

## **How Ollama Is Used in This Project**

Ollama is used as a **local inference engine** for the AI agent.
The Microsoft Agent framework communicates with Ollama to:

* Interpret user input
* Generate task-oriented responses
* Demonstrate agent-based execution flow

This design supports the **educational goal** of the project by allowing students to observe how AI agents interact with application logic **without relying on cloud services**.

---

## **Project Structure Overview**

```
BlazorTaskAgent/
│
├── Agents/                # AI agent logic
│   └── TaskPlannerAgent.cs
│
├── Pages/                 # Blazor pages
│   ├── Index.razor        # Agent interface
│   ├── TicTacToe.razor    # Tic-Tac-Toe game
│
├── Shared/
│   └── NavMenu.razor      # Navigation menu
│
├── wwwroot/               # Static files
├── Program.cs             # Application entry point
└── BlazorTaskAgent.csproj
```

---

## **Educational Purpose**

This project is developed **strictly for educational purposes** as part of the
**TPL6213 Programming Language Concepts** course at **Multimedia University (MMU)**.

All code examples are intended to explain programming language concepts.

**The sample application is designed to demonstrate programming language concepts rather than to provide a production-ready AI system.**

---

## **Assessment Alignment (TPL6213)**

This project addresses:

* Background of programming language and tools
* Explanation of language elements using source code
* Development of a working sample application
* Demonstration and training preparation
* Web-based documentation and reporting

---

## **References**

* Microsoft. (2024). *C# Documentation*.
  [https://learn.microsoft.com/en-us/dotnet/csharp/](https://learn.microsoft.com/en-us/dotnet/csharp/)

* Microsoft. (2024). *ASP.NET Core Blazor*.
  [https://learn.microsoft.com/en-us/aspnet/core/blazor/](https://learn.microsoft.com/en-us/aspnet/core/blazor/)

* Microsoft. (2024). *Semantic Kernel Documentation*.
  [https://learn.microsoft.com/en-us/semantic-kernel/](https://learn.microsoft.com/en-us/semantic-kernel/)

* Ollama. (2024). *Ollama Documentation*.
  [https://ollama.com/](https://ollama.com/)

---

## **Contributors**

TPL6213 Group Project
Multimedia University (MMU)

---
