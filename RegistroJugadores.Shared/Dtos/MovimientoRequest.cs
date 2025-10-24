﻿namespace RegistroJugadores.Shared.Dtos;

public record MovimientoRequest(
    int PartidaId,
    string Jugador,
    int PosicionFila,
    int PosicionColumna
);
