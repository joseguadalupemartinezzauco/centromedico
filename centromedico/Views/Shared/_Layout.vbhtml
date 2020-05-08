﻿<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="~/Content/estilos.css">
    <title>@ViewBag.Title - Mi aplicación ASP.NET</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr") 
</head>
<body>
    <header>
        <div class="wrapp">
            <ul class="nav navbar-nav">
                <li class="men">@Html.ActionLink("CentroMedico", "Index", "Home")</li>
                <li class="men">@Html.ActionLink("Salir", "Contact", "Home")</li>
            </ul>
        </div>
    </header>
    <div>
        <aside>
            <div class="widget">
                <ul class="nav">
                    <li class="men">@Html.ActionLink("Inicio", "Index", "Home")</li>
                    <li class="men">@Html.ActionLink("Citas", "citas", "Home")</li>
                    <li class="men">@Html.ActionLink("Medicos", "medicos", "Home")</li>
                    <li class="men">@Html.ActionLink("Pacientes", "pacientes", "Home")</li>
                    <li class="men">@Html.ActionLink("Consultorios", "consultorios", "Home")</li>
                    <li class="men">@Html.ActionLink("Especialidades", "especialidades", "Home")</li>
                    <li class="men">@Html.ActionLink("Usuarios", "usuarios", "Home")</li>
                    <li class="men">@Html.ActionLink("Reportes", "reportes", "Home")</li>
                </ul>
            </div>
        </aside>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
    </div>
    <div>
        <footer>
            <p>Copyright © 2020 <a target="_blank" : href="#" title="Jose Guadalupe">Jose Guadalupe</a></p>
        </footer>

    </div>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
