# Lets Learn Dot Net

# 🧠 Introduction to .NET Framework – Quick Reference

## 🔹 What is a Framework?

A **framework** is a collection of small, integrated technologies that help you build and run applications **across platforms**.

> 💡 Think of it like a **toolkit + runtime + libraries** to build apps faster and smarter.

---

## 🔹 What Does the .NET Framework Provide?

1. **BCL (Base Class Library)** – Core reusable classes (collections, I/O, strings, etc.)
2. **CLR (Common Language Runtime)** – Engine that runs your code, manages memory, and compiles it.

---

## 🔸 What is BCL?

- **BCL = Base Class Library**
- Contains classes like `List`, `File`, `DateTime`, etc.
- You **can't write .NET code without it**.
  
> 🧰 It's the toolbox every .NET developer uses every day.

---

## 🔸 What is CLR?

- **CLR = Common Language Runtime**
- Core part of .NET
- It:
  - Converts your code into native OS code
  - Manages memory
  - Handles exceptions
  - Runs garbage collection

> 🧠 Think of CLR as the **brain and bodyguard** of your app.

---

## 🔸 Two-Step Compilation

1. **Step 1**: Source Code ➡️ MSIL/IL (Intermediate Language)
2. **Step 2**: IL ➡️ Native Code (by CLR)

---

## 🔸 What is JIT?

- **JIT = Just-In-Time Compiler**
- Part of the CLR
- Converts **IL code to native code** just before execution

> 🧩 Like Google Translate – it translates your logic to the OS language right before speaking!

---

## 🔸 .NET Framework Types

| Type            | Description                                                                 |
|-----------------|-----------------------------------------------------------------------------|
| .NET Framework  | Windows-only, platform dependent                                            |
| .NET (.NET Core) | Cross-platform (Windows, Linux, macOS), open-source                        |
| Xamarin / Mono  | Mobile app development (Android, iOS, etc.)                                 |

> ⚠️ **.NET Framework = Windows-only**  
> ✅ **.NET Core = Cross-platform & faster**

---

## 🔸 Technologies Supported in .NET

- **ASP.NET** – MVC, Web API, Blazor, etc.
- **ADO.NET** – Data access
- **WCF** – Communication (services)
- **WPF** – Desktop GUI
- **WWF** – Workflows
- **AJAX** – Async frontend
- **LINQ** – Query data like SQL in C#
- **Entity Framework** – ORM for DB access

---

# ♻️ Garbage Collection in .NET (.NET GC)

## 🔹 What is Garbage Collection?

Garbage Collection in .NET is an **automatic memory management system**. It:

- Frees memory occupied by objects no longer in use.
- Prevents memory leaks and crashes.
- [CLR] Runs **automatically** — no need to manually `free()` like in C/C++.

---

## 🔍 Why is it Needed?

Without GC, unused objects would stay in memory forever, causing **OutOfMemoryExceptions**.  
GC ensures your application uses memory **efficiently and safely**.

---
### 🧠 Real-Life Analogy:
> Like a **cleaning robot** in your app’s memory — it finds unused objects and throws them away.

---

## 🔸 Managed vs Unmanaged Objects

| Type          | Description                                       |
|---------------|---------------------------------------------------|
| Managed       | Created in .NET (C#, VB.NET) – handled by CLR     |
| Unmanaged     | From outside .NET (C, C++, Java EXEs) – NOT handled by CLR |

> E.g., Excel/Skype = Unmanaged  
> Your .NET app = Managed

---

## 🔸 GC Generations

| Generation | Description                    | Lifetime of Objects            |
|------------|--------------------------------|--------------------------------|
| Gen 0      | Newly created objects          | Very short-lived               |
| Gen 1      | Survived one GC cycle (Gen 0)  | Medium-lived objects           |
| Gen 2      | Survived multiple GC cycles    | Long-lived / Persistent objects|

> 🧠 Memory Trick:  
> **0 → newborn, 1 → teen, 2 → adult**

---

## 🔸 .NET Memory Profiler

A tool to:
- Detect **memory leaks**
- Track down heavy memory usage
- Optimize performance

Used in real-world apps to keep them **fast and clean**.

---

## 📌 Summary Table

| Concept     | What It Does                                                |
|-------------|-------------------------------------------------------------|
| Framework   | Toolkit for app development                                 |
| BCL         | Built-in .NET libraries                                     |
| CLR         | Executes code and manages memory                            |
| JIT         | Converts IL to native code                                  |
| GC          | Frees memory by cleaning unused objects                     |
| Gen 0-2     | GC tracks object lifespan                                   |
| .NET Types  | Framework (.NET), Cross-platform (.NET Core), Mobile (Xamarin) |
| Profiler    | Analyzes and fixes memory issues                            |

---

