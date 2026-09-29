# Advanced Query Building Techniques: Join Two Tables Using Blazor Query Builder

## Overview

This sample demonstrates how to use the Syncfusion [Blazor Query Builder](https://www.syncfusion.com/blazor-components/blazor-query-builder) with complex data binding scenarios that involve related data from multiple tables. The implementation focuses on exposing fields from associated entities so that users can build filtering conditions across joined data structures through a visual query-building interface.

This approach is useful in business applications where filtering requirements span multiple related datasets. By leveraging complex object binding, the Query Builder can generate rules that represent conditions across parent and related records without requiring users to write SQL queries manually.

## Key Features

- Demonstrates advanced query construction using the Syncfusion Query Builder component.
- Shows complex data binding techniques for working with data originating from multiple related tables.
- Enables rule creation across fields exposed from associated entities.
- Provides a visual query-building experience for multi-table filtering scenarios.
- Uses Query Builder column definitions to map fields from complex object structures.
- Illustrates how users can create conditions that represent table-join style filtering requirements.
- Includes a complete Blazor application project for hosting the Query Builder implementation.
- Demonstrates a practical data exploration workflow using hierarchical or related data models.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open the solution file:

   `SyncfusionBlazorApp.sln`

3. Restore all NuGet packages.
4. Set the startup project 
5. Build the solution.
6. Run the application using **Ctrl+F5**.
7. Open the local URL displayed by the ASP.NET Core host after startup.

**Visual Studio Code**

1. Clone or download this repository.
2. Open the repository folder in Visual Studio Code.
3. Open the integrated terminal.
4. Navigate to the project directory:

```bash
cd SyncfusionBlazorApp
```

5. Restore NuGet packages:

```bash
dotnet restore
```

6. Run the application:

```bash
dotnet run
```

7. Open the local application URL displayed in the terminal after the application starts successfully.

## Project Structure

`SyncfusionBlazorApp/Pages/Index.razor` — primary page containing the Query Builder implementation and complex data-binding scenario. 

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- Official documentation for the demonstrated feature: https://blazor.syncfusion.com/documentation/query-builder/data-binding#complex-data-binding

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.