# BlazorDeepDive — Project CLAUDE.md

## Purpose
Deep-dive learning project for Blazor Web Apps (.NET 10). Each session explores a specific Blazor concept through hands-on implementation. Code is intentionally exploratory — comments explaining "why" are expected and encouraged.

## Solution Structure
```
BlazorDeepDive/
├── BlazorDeepDive.slnx              # Solution file (VS 2022+ format)
└── ServerManagement/
    ├── ServerManagement.csproj      # net10.0, Nullable enabled, ImplicitUsings enabled
    ├── Program.cs                   # App startup, middleware, service registration
    └── Components/
        ├── App.razor                # Root HTML shell — loads CSS, scripts, <Routes />
        ├── Routes.razor             # Router: maps URLs → components, NotFound fallback
        ├── _Imports.razor           # Global @using directives for all components
        ├── Pages/
        │   ├── Home.razor           # @page "/"
        │   ├── Weather.razor        # @page "/weather"
        │   ├── NotFound.razor       # @page "/not-found" — custom 404 page
        │   └── Error.razor          # Error boundary page
        └── Layout/
            ├── MainLayout.razor     # Default layout — sidebar + main content area
            └── NavMenu.razor        # Sidebar nav with NavLink components
```

## Architecture Decisions
- **Render mode**: Static SSR by default — no `@rendermode` set globally or per-page yet
- **Router**: `Routes.razor` uses `NotFoundPage="typeof(Pages.NotFound)"` for custom 404
- **404 handling**: `UseStatusCodePagesWithReExecute("/not-found")` in `Program.cs` handles unknown URLs at the middleware level; `NotFoundPage` on the `<Router>` handles routes not matched by Blazor's router
- **`BlazorDisableThrowNavigationException=true`**: suppresses `NavigationException` thrown during SSR navigation redirects — keeps logs clean during normal navigation
- **Layout**: `MainLayout` is the default; `NotFound.razor` overrides it explicitly with `@layout MainLayout`

## Concepts Covered (log additions here)
- Routable components (`@page` directive, `<Router>`, `RouteView`, `NotFoundPage`)
- 404 / status code handling (`UseStatusCodePagesWithReExecute`)

## Conventions
- Follow `~/.claude/skills/csharp-conventions/` for C#/Blazor patterns
- Explanatory comments are fine — this is a learning repo
- New pages go in `Components/Pages/`
- New reusable UI components go in `Components/` (create subfolders as needed)
- New layouts go in `Components/Layout/`
- Do not add interactive render modes to existing pages unless the current concept requires interactivity

## Running the App
```bash
cd ServerManagement
dotnet run
# or
dotnet watch
```
