    namespace RegistroJugadores.Shared.Dtos;

    public record MovimientoResponse(
        int MovimientoId,
        string Jugador,
        int PosicionFila,
        int PosicionColumna
    );
