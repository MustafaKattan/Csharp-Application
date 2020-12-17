using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Applicatie
{
    class GebruikerBLL
    {
        // Methods 
        // CREATE
        public int Create(GebruikerBO gebruiker)
        {
            GebruikerDAL gebruikerDAL = new GebruikerDAL();
            return gebruikerDAL.Create(gebruiker);
        }
        // READ
        public DataSet Read()
        {
            GebruikerDAL gebruikerDAL = new GebruikerDAL();
            return gebruikerDAL.Read();
        }

        // Read één gebruiker
        public DataSet ReadGebruiker(GebruikerBO gebruiker)
        {
            GebruikerDAL gebruikerDAL = new GebruikerDAL();
            return gebruikerDAL.ReadGebruiker(gebruiker);
        }
        // Gebruikersgegevens - Account aanmaken
        public bool GebruikersNaam(GebruikerBO gebruiker)
        {
            GebruikerDAL gebruikerDAL = new GebruikerDAL();
            return gebruikerDAL.GebruikersNaam(gebruiker);
        }
        // Gebruikersgegevens - Inloggen
        public bool Gebruikersgegevens(GebruikerBO gebruiker)
        {
            GebruikerDAL gebruikerDAL = new GebruikerDAL();
            return gebruikerDAL.Gebruikersgegevens(gebruiker);
        }
        // Get the ID
        public int GetID(GebruikerBO gebruiker)
        {
            GebruikerDAL gebruikerDAL = new GebruikerDAL();
            return gebruikerDAL.GetID(gebruiker);
        }
        // Get The Rol
        public string GetRol(GebruikerBO gebruiker)
        {
            GebruikerDAL gebruikerDAL = new GebruikerDAL();
            return gebruikerDAL.GetRol(gebruiker);
        }
        // UPDATE
        public bool Update(GebruikerBO gebruiker)
        {
            GebruikerDAL gebruikerDAL = new GebruikerDAL();
            return gebruikerDAL.Update(gebruiker);
        }
        // DELETE
        public bool Delete(GebruikerBO gebruiker)
        {
            GebruikerDAL gebruikerDAL = new GebruikerDAL();
            return gebruikerDAL.Delete(gebruiker);
        }

    }
}
