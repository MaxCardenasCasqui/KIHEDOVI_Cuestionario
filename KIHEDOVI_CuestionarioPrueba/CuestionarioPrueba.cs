using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KIHEDOVI_Cuestionario;

namespace KIHEDOVI_CuestionarioPrueba
{
    [TestClass]
    public class CuestionarioPrueba
    {
        /// <summary>Pruebas the titulo.</summary>
        [TestMethod]
        public void Prueba_Titulo()
        {
            //Arranque
            String titulo = "matematica";
            Boolean rpta;
            KIHEDOVI_Cuestionario.FormCrearCuestionario tl = new KIHEDOVI_Cuestionario.FormCrearCuestionario();

            //Act


            //Assert
            Assert.AreEqual(true, titulo);
        }

        /// <summary>Pruebas the codigo.</summary>
        [TestMethod]
        public void Prueba_Codigo()
        {
            //Arranque
            String codigo = "matematica";
            Boolean rpta;
            KIHEDOVI_Cuestionario.FormCrearCuestionario cod = new KIHEDOVI_Cuestionario.FormCrearCuestionario();

            //Act


            //Assert
            Assert.AreEqual(true, codigo);
        }

        /// <summary>Pruebas the pregunta.</summary>
        public void Prueba_Pregunta()
        {
            //Arranque
            String codigo = "matematica";
            Boolean rpta;
            KIHEDOVI_Cuestionario.FormCrearCuestionario cod = new KIHEDOVI_Cuestionario.FormCrearCuestionario();

            //Act


            //Assert
            Assert.AreEqual(true, codigo);
        }
    }
}
