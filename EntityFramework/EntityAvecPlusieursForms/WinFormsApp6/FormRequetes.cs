using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp6.Models;

namespace WinFormsApp6
{
    public partial class FormRequetes : Form
    {
        CitiesContext dbContext;
        public FormRequetes()
        {
            InitializeComponent();
            //Creer le context vers la source
            dbContext = new CitiesContext();
            //Chargement de la table Cities
            dbContext.Cities.Load();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            //requete sur une seule table Cities qui return qu'un seul type exemple City
            List<City> citiesList = dbContext.Cities.FromSql<City>($"select * from Cities").ToList();
        }

        private void buttonSelectWhere_Click(object sender, EventArgs e)
        {
            string propertyName = "city_name";
            SqlParameter columnValue = new SqlParameter("columnValue", "Paris");
            //requete sur une seule table Cities qui return qu'un seul type exemple City eta qui on passe un sql parameter
            var citiesList = dbContext.Cities.FromSqlRaw<City>($"select * from Cities WHERE {propertyName} = @columnValue", columnValue).ToList();
        }

        private void buttonSelectAvecLink_Click(object sender, EventArgs e)
        {
            //var searchTerm = "Lorem ipsum";

            var blogs = dbContext.Cities
                .FromSql($"SELECT * FROM Cities")
                .Where(c => c.CityName.Length < 6)
                .OrderByDescending(c => c.CityName)
                .ToList();

            var test = (from 
                        Cities in dbContext.Cities 
                        join 
                        Countries in dbContext.Countries 
                        on Cities.CountryCode equals Countries.CountryCode
                        select new { productID = Cities.CityId, 
                                    productName = Cities.CityName, 
                                    countryCode = Cities.CountryCode, 
                                    countryName = Countries.CountryName })
                        .ToList();

            //requete sur plusieurs tables qui return qu'un seul type exemple City
            //dbContext.Database.SqlQuery<City>(...)
        }

        /*
         FromSql	This method returns a DbSet of the specified type T, where T is the model representing the data returned from the query
SqlQuery	This method returns an IEnumerable of the specified type T, where T is the model representing the data returned from the query.
ExecuteSql	This method is used to execute a 
         */
    }
}
