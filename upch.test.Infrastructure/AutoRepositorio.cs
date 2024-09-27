using upch.test.Domain.Dtos;
using upch.test.Domain.Entities;
using upch.test.Domain.Interfaces;
using Dapper;
using Npgsql;
using System.Data;
using System.Data.Common;

namespace upch.test.Infrastructure
{
    public class AutoRepositorio :IAutoRepositorio //implementacion desacoplada del repositorio
    {
        private readonly IContainerCadenaConexion _cadenaConexion;

        public AutoRepositorio(IContainerCadenaConexion cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        public async ValueTask<Auto?> Crear(Auto? _nuevoAuto) 
        {
            using (var dbConnection = new NpgsqlConnection(_cadenaConexion.ConnString))
            {
                // Realiza una consulta con Dapper
                string insertQuery = @"
                INSERT INTO auto 
                (
                    cantidad_plazas, 
                    tipo_caja_cambios, 
                    tipo_motor, 
                    cantidad_puertas, 
                    peso, 
                    tipo_combustible, 
                    color, 
                    marca, 
                    modelo, 
                    kilometraje, 
                    anio) 
                VALUES 
                (
                    @CantidadPlazas, 
                    @TipoCajaCambios, 
                    @TipoMotor, 
                    @CantidadPuertas, 
                    @Peso, 
                    @TipoCombustible, 
                    @Color, 
                    @Marca, 
                    @Modelo, 
                    @Kilometraje, 
                    @Anio);";//ojo es una consulta parametrizada para evitar inyecciones sql
                using (var connection = new NpgsqlConnection(_cadenaConexion.ConnString))
                {
                    dbConnection.Open();
                    await connection.ExecuteAsync(insertQuery, _nuevoAuto);
                }
            }

            return _nuevoAuto;
        }

        public async ValueTask<Auto?> ObtenerAuto(int _id) 
        {
            var query = @"SELECT
                    id_auto as IdAuto,
                    cantidad_plazas AS CantidadPlazas,
                    tipo_caja_cambios AS TipoCajaCambios,
                    tipo_motor AS TipoMotor,
                    cantidad_puertas AS CantidadPuertas,
                    peso,
                    tipo_combustible AS TipoCombustible,
                    color,
                    marca,
                    modelo,
                    kilometraje,
                    anio
                    from auto WHERE id_auto=@IdAuto";
            var autoEncontrado = default(Auto);
            using (var connection = new NpgsqlConnection(_cadenaConexion.ConnString))
            {
                autoEncontrado = await connection.QuerySingleOrDefaultAsync<Auto>(query, new { IdAuto = _id });
            }
            return autoEncontrado;
        }

        public async ValueTask<int> ActualizarAuto(Auto? _dto)
        {
            int filasAfectadas = 0;
            // Consulta SQL para actualizar un auto basado en el ID
            string updateQuery = @"
                UPDATE auto
                SET 
                    cantidad_plazas = @CantidadPlazas,
                    tipo_caja_cambios = @TipoCajaCambios,
                    tipo_motor = @TipoMotor,
                    cantidad_puertas = @CantidadPuertas,
                    peso = @Peso,
                    tipo_combustible = @TipoCombustible,
                    color = @Color,
                    marca = @Marca,
                    modelo = @Modelo,
                    kilometraje = @Kilometraje,
                    anio = @Anio
                WHERE id_auto = @IdAuto;";
            using (var dbConnection = new NpgsqlConnection(_cadenaConexion.ConnString))
            {
                dbConnection.Open();
                // Ejecutar la consulta y pasar el objeto con los valores actualizados
                filasAfectadas = await dbConnection.ExecuteAsync(updateQuery, _dto);
            }
            return filasAfectadas;
        }
        public async ValueTask<bool> EliminarAuto(int Id)
        {
            var query = "DELETE FROM auto WHERE id_auto = @id;";
            int filasAfectadas = 0;
            using (var dbConnection = new NpgsqlConnection(_cadenaConexion.ConnString))
            {
                dbConnection.Open();
                // Ejecutar la consulta y pasar el objeto con los valores actualizados
                filasAfectadas = await dbConnection.ExecuteAsync(query, new { Id = Id});
            }
            return filasAfectadas == 0? false:true;
        }
    }
}