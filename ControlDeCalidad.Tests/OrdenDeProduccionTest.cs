using System;
using System.Collections.Generic;
using ControlDeCalidad.Api.Entidades;
using ControlDeCalidad.DominioBackend.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControlDeCalidad.Tests
{
    [TestClass]
    public class OrdenDeProduccionTest
    {


        [TestMethod]
        public void TestCrearNuevaOrdenDeProduccionConEstadoActiva()
        {

        //Arrange
        int numeroOrden = 1;
        Color color = new Color()
        {
            codigo = 1,
            descripcion = "Rojo"
        };
        Modelo modelo = new Modelo()
        {
            SKU = 1,
            descripcion = "Nike",
            objetivo = 45
        };
        OrdenDeProduccion orden = new OrdenDeProduccion(numeroOrden, modelo, color);
        //Act

        //Assert

            Assert.AreEqual(EstadoOrden.Activa,orden.Estado);
        }

        [TestMethod]
        public void TestComprobarQueTodasLasOPEstenFinalizadas()
        {
            //Arrange
            LineaDeTrabajo linea = new LineaDeTrabajo()
            {
                Empleado = new Empleado(),
                numeroLinea = 1,
                ordenes = new List<OrdenDeProduccion>()
                {
                    new OrdenDeProduccion(2,new Modelo(), new Color())
                    {
                        Estado = EstadoOrden.Finalizada
                    },
                    new OrdenDeProduccion(3,new Modelo(), new Color())
                    {
                        Estado = EstadoOrden.Finalizada
                    },
                    new OrdenDeProduccion(4,new Modelo(), new Color())
                    {
                        Estado = EstadoOrden.Finalizada
                    },
                    new OrdenDeProduccion(5, new Modelo(), new Color())
                    {
                        Estado = EstadoOrden.Finalizada
                    },
                }
            };
            //Act
            var validacion = linea.ValidarOrden();
            //Assert
            Assert.AreEqual(true,validacion);
        }

        [TestMethod]
        public void TestCreacionDeOPDentroDeUnTurnoValido()
        {
            //Arrange
            string horaActual = "17:00";
            var turnos = new List<Turno>()
            {
                new Turno()
                {
                    inicio = "17:00",
                    fin = "20:00"
                },
                new Turno()
                {
                    inicio = "20:00",
                    fin = "23:00"
                }
            };
            LineaDeTrabajo linea = new LineaDeTrabajo()
            {
                Empleado = new Empleado(),
                numeroLinea = 1,
                ordenes = new List<OrdenDeProduccion>()
                {
                    new OrdenDeProduccion(2,new Modelo(), new Color())
                    {
                        Estado = EstadoOrden.Finalizada
                    },
                    new OrdenDeProduccion(3,new Modelo(), new Color())
                    {
                        Estado = EstadoOrden.Finalizada
                    },
                    new OrdenDeProduccion(4,new Modelo(), new Color())
                    {
                        Estado = EstadoOrden.Finalizada
                    },
                    new OrdenDeProduccion(5, new Modelo(), new Color())
                    {
                        Estado = EstadoOrden.Finalizada
                    },
                }
            };
            //Act
            var validacion = linea.validarTurno(horaActual, turnos);
            //Assert
            Assert.AreEqual(true, validacion);
        }

        [TestMethod]
        public void TestComprobarQueParDePrimeraSeIncrementeEnUno()
        {
            //Arrange
            var acumulador = 0;
            Jornada jornada = new Jornada()
            {
                Inspecciones = new List<Inspeccion>()
                {
                    new Inspeccion()
                    {
                        esDePrimera = true,
                        Hora = "14:00"
                    }
                }
            };
            string hora1 = "17:00";
            string hora2 = "17:15";

            //Act

            jornada.agregarInspeccionPrimera(hora1);
            jornada.agregarInspeccionPrimera(hora2);

            foreach (var jor in jornada.Inspecciones)
            {
                if (jor.esDePrimera)
                {
                    acumulador += 1;
                }
            }

            //Assert
            Assert.AreEqual(acumulador, 3);
        }

        [TestMethod]
        public void TestComprobarQueDefectosSeIncrementeEnUno()
        {
            //Arrange
            var acumulador = 0;
            var defecto = new Defecto()
            {
                Tipo = TipoDefecto.Observado,
                Descripcion = "Roto"
            };
            var defecto2 = new Defecto()
            {
                Tipo = TipoDefecto.Observado,
                Descripcion = "Mal pegado"
            };

            Jornada jornada = new Jornada()
            {
                Inspecciones = new List<Inspeccion>()
                {
                    new Inspeccion()
                    {
                        esDePrimera = true,
                        Hora = "14:00"
                    }
                }
            };
            string hora1 = "17:00";
            string hora2 = "17:15";

            //Act

            jornada.agregarInspeccionDefecto(hora1, defecto,TipoPie.Derecho);
            jornada.agregarInspeccionDefecto(hora2, defecto2, TipoPie.Izquierdo);

            foreach (var jor in jornada.Inspecciones)
            {
                if (!jor.esDePrimera)
                {
                    acumulador += 1;
                }
            }

            //Assert
            Assert.AreEqual(acumulador, 2);
        }
    }

   
}
