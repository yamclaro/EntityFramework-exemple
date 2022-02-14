using System.Reflection;
using System;

namespace ProjetoDominandoEntity
{
    class program
    {
        static void Main(string[] args)
        {
            EnsureCreateAndDeleted();
        }
        static void EnsureCreateAndDeleted()
        {
            using var db = new ProjetoDominandoEntity.Data.AplicationContext();
            db.Database.EnsureCreated();
        }
    }
} 

