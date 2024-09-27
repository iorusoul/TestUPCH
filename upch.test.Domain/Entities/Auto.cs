﻿using upch.test.Domain.Enums;

namespace upch.test.Domain.Entities
{
    public class Auto
    {
        public int IdAuto { get; set; }
        public int CantidadPlazas { get; set; }
        public TipoCajaCambios TipoCajaCambios { get; set; }
        public TipoMotor TipoMotor { get; set; }
        public int CantidadPuertas { get; set; }
        public float Peso { get; set; }
        public TipoCombustible TipoCombustible { get; set; }
        public string? Color { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Kilometraje { get; set; }
        public int Anio { get; set; }
    }
}