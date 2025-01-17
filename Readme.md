# Unity with Sails.Net for Vara Network Template

This repository provides a template for integrating Unity projects with the Vara Network using a backend powered by Sails.Net. It includes examples and utilities to facilitate seamless communication between Unity, Sails.Net, and the Vara Network.


## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [License](#license)

## Introduction

The Unity with Sails.Net Template is designed to streamline the development of Unity projects that require a .NET backend using Sails.Net. It provides a basic setup for client-server communication and demonstrates how to manage requests and responses efficiently.

## Prerequisites

Before getting started, ensure you have the following installed:

- [Unity](https://unity.com/) (version 2019.4 or higher)
- [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0 or higher)
- [Sails.Net framework](https://github.com/gear-tech/sails.git) (installed in your .NET project)

## Adding Sails.Net Dependencies

To integrate Sails.Net into your Unity project, follow these steps:

1. **Clone the Sails.Net repository**:

   Clone the official Sails.Net repository to your local environment:

   ```sh
   git clone https://github.com/gear-tech/sails.git
   ```
2. **Modify the Sails.Net.csproj file**:

    Open the Sails.Net.csproj file and add the following property inside the <PropertyGroup> section to enable local file assembly copying:
    ```sh
    <PropertyGroup>
    <CopyLocalLockFileAssemblies>true</CopyLocalLockFileAssemblies>
    </PropertyGroup>
    ```
3. **Build the dependencies:**

    Navigate to the Sails.Net directory and run the following command to build the project:
    
    ```sh
    dotnet build
    ```
4. **Copy the dependencies**:

After building the project, copy the dependencies from the following folder:
    

     sails.Net/bin/Debug/netstandard2.0

5. Add dependencies to Unity:

 Paste the copied dependencies into the Assets/Plugins folder in your Unity project to make them accessible within Unity.


## Installation

To set up and use this template, follow these steps:

1. Clone the repository:

   ```sh
   git clone https://github.com/Vara-Lab/SDK-Unity-Vara-Template.git
   ```
2. Open the Unity project:

- Open Unity Hub.
- Click "Add" and navigate to the Unity-SailsNet-Template folder.
- Select the folder and click "Open".

## Contributing

We welcome contributions to this project! If you'd like to contribute, please follow these guidelines:

1. **Fork the Repository**:  
   Click on the "Fork" button at the top of this repository to create your own copy.

2. **Create a Feature Branch**:  
   Create a new branch for your feature or bugfix.
   ```bash
   git checkout -b feature/your-feature-name
   ```

3. **Submit a Pull Request**:  
   Once your changes are ready, submit a pull request to the `main` branch. Be sure to include a detailed description of your changes and the problem they solve.