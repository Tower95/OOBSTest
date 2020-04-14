using System;
using Raven.Client.Documents;
using Raven.Client.Documents.Session;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODBTestClassLibrary
{
    public class PersonaDBServices
    {
        public void GuardarPersona(Persona persona)
        {
            Persona Persona = new Persona();
            Persona.Nombre = "Ismael";
        }

        public void GuardarListaPersonas(List<Persona> lista_personas)
        {
        }

        public List<Persona> ListaPersonas()
        {
            return;
        }

        public List<Persona> BuscarPersonaPorApellido(string apellido)
        {
            return;
        }

        public List<Persona> BuscarPersonaPorEdad(int edad1, int edad2)
        {
            return;
        }

        public void UpdatePersona(Persona persona)
        {

        }

        public void UpdateListaPersonas(List<Persona> lista_personas)
        {

        }

   
         
    }
}
