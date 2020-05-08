﻿@Code
    ViewData("Title") = "AgregarCita"
End Code

<section class="main">     
    <article>
        <div class="wrapp">
            <div class="mensaje">
                <h2>CITA</h2>
            </div>
            <form action="" method="post">
                <h2>Agregar Citas</h2>
                <label>Fecha:</label> 
                <input type="date" name="fecha" placeholder="Fecha:" required ><br />
                <label>Hora:</label>
                <input type="time" name="hora" value="11:45" max="20:30" min="08:00" step="60" required>
                <label>Paciente:</label>
                <input required type="text" name="paciete" placeholder="">
                <label>Medicos:</label>
                <input required type="text" name="paciete" placeholder="">
                <label>Consultorios:</label>
                <input required type="text" name="paciete" placeholder="">
                <label>Estado:</label>
                <select name="estado">
                    <option value="asignado">Asignado</option>
                    <option value="atendido">Atendido</option>
                </select>
                <label>Observaciones:</label>
                <textarea placeholder="Observacion:" name="observaciones"></textarea>

                <input type="submit" name="enviar" value="Agregar Cita">
            </form>
        </div>
    </article>
</section>

