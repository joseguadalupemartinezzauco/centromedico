﻿@Code
    ViewData("Title") = "medicos"
End Code

<section class="main">
    <article>
        <div class="wrapp">
            <?php include 'plantillas/nav.php'; ?>

            <div class="mensaje">
                <h2>MEDICOS</h2>
            </div>
            <a href="agregarmedicos.php" class="agregar">Agregar Medico</a>

            <table class="tabla">
                <tr>
                    <th>Identificacion</th>
                    <th>Nombre</th>
                    <th>Apellidos</th>
                    <th>Correo</th>
                    <th>Cargo</th>
                    <th colspan="2">Opciones</th>

                </tr>

                <tr>
                </tr>
            </table>
        </div>
    </article>
</section>

