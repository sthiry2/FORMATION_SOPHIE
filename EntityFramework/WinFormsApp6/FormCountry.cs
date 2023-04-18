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
    public partial class FormCountry : Form
    {
        private CitiesContext dbContext;
        public FormCountry()
        {
            InitializeComponent();
            //Creer le context vers la source
            dbContext = new CitiesContext();
            //Chargement de la table Cities
            dbContext.Countries.Load();

            //Realisation d'un binding entre la source de donnée Cities et le datagridview
            this.dataGridViewCountries.DataSource = dbContext.Countries.Local.ToBindingList(); ;

        
        }

        private void buttonAjouterUn_Click(object sender, EventArgs e)
        {


            Country c = new Country();
            c.CountryName = "PewPewLand";
            c.CountryCode = "PP";


            Trace("Avant de l'avoir Add");
            dbContext.Countries.Add(c);
            Trace("Apres de l'avoir Add");

            dbContext.SaveChanges();

            Trace("Apres de avoir sauvegardé les changements: un INSERT à été réalisé sur la BD");
        }

        private void buttonSuprimerUn_Click(object sender, EventArgs e)
        {

        }

        private void buttonSupprimerCountry_Click(object sender, EventArgs e)
        {
            // ne marche pas
            //https://stackoverflow.com/questions/16194162/entitystate-deleted-does-not-work-removeentity-does
            if (this.textBoxId.Text.Length!=0)
            {
                Country cASupprimer = new Country() { CountryCode = this.textBoxId.Text };
                dbContext.Entry(cASupprimer).State = EntityState.Deleted;

                Trace("Apres l'avoir dit quel Country à definir comme supprimer");

                dbContext.SaveChanges();
                Trace("Apres avoir sauvegardé les changements: un DELETE à été réalisé sur la BD");
            }
        }

        private void buttonModifyUn_Click(object sender, EventArgs e)
        {

        }

        private void Trace(string message)
        {
            textBoxConsole.Text += "-----------------------" + message + "------------------------" + Environment.NewLine;
            dbContext.ChangeTracker.DetectChanges();
            textBoxConsole.Text += dbContext.ChangeTracker.DebugView.LongView;
        }
    }
}
