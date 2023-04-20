using ClassLibraryCities;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormUnCity : Form
    {
        CCity monCity;

        CitiesContext context;

        //mode creation
        public FormUnCity(CitiesContext context)
        {
            InitializeComponent();
            this.context = context;
            context.Countries.Load<Country>();
            this.comboBox1.DataSource = this.context.Countries.Local.ToBindingList();
            this.comboBox1.ValueMember = "CountryCode";
        }

        //mode modification
        public FormUnCity(CitiesContext context,CCity cityAModifier)
        {
            monCity= cityAModifier;

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            //creer l'objet metier
            monCity = new CCity(this.textBoxNom.Text,((Country)this.comboBox1.SelectedItem).CountryCode);
            
            //sauvegarder l'objet metier ds BD
            City city = new City();
            city.CityName = monCity.NomCity;
            city.CountryCode = monCity.CodeCountry;

            context.Cities.Add(city);
            context.SaveChanges();

            monCity.Id = city.CityId;

            this.Close();

        }
    }
}
