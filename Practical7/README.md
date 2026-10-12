# Practical 7 — Student Feedback Management Module

ASP.NET MVC application for collecting and displaying student feedback using shared layouts, partial views, and HTML helpers.

## How to Run
Open `prac7.sln` in Visual Studio and press `F5`.

## Concepts
- ASP.NET MVC Shared Layouts (`_LayoutView.cshtml` with `@RenderBody()`)
- Partial Views (`_StudentInfo.cshtml` rendered via `@Html.Partial`)
- Form generation using strongly-typed HTML Helpers (`Html.BeginForm`, `Html.LabelFor`, `Html.EditorFor`, `Html.TextBoxFor`)
- In-memory data persistence across requests using a static collection in `FeedbackController`
- Tabular display of submitted feedbacks using Razor foreach loops
